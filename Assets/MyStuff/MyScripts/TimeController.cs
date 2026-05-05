using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class TimeController : MonoBehaviour
{

    // Script by Brandon Foshe, derived from Youtube Tutorial

    [SerializeField]
    private float timeMultiplier, startHour, sunriseHour, sunsetHour;

    [SerializeField]
    private Light sunLight;

    [SerializeField]
    private TextMeshProUGUI timeText;

	private DateTime currentTime;
    private TimeSpan sunriseTime, sunsetTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTime = DateTime.Now.Date + TimeSpan.FromHours(startHour);

        sunriseTime = TimeSpan.FromHours(sunriseHour);
        sunsetTime = TimeSpan.FromHours(sunsetHour);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimeOfDay();
        RotateSun();
    }

    private void UpdateTimeOfDay(){
        currentTime = currentTime.AddSeconds(timeMultiplier * Time.deltaTime);

        if(timeText != null){
            timeText.text = currentTime.ToString("HH:mm");
        }
    }

    private TimeSpan CalculateTimeDifference(TimeSpan fromTime, TimeSpan toTime){
        TimeSpan difference = toTime - fromTime;

        if (difference.TotalSeconds < 0){
            difference += TimeSpan.FromHours(24);
        }

        return difference;
    }

    private void RotateSun(){
        float sunLightRotation;

        if(currentTime.TimeOfDay > sunriseTime && currentTime.TimeOfDay < sunsetTime){
            TimeSpan sunriseToSunsetDuration = CalculateTimeDifference(sunriseTime,sunsetTime);
            TimeSpan timeSinceSunrise = CalculateTimeDifference(sunriseTime, currentTime.TimeOfDay);

            double percentage = timeSinceSunrise.TotalMinutes / sunriseToSunsetDuration.TotalMinutes;
            sunLightRotation = Mathf.Lerp(0, 180, (float)percentage);
        }
        else{
            TimeSpan sunsetToSunriseDuration = CalculateTimeDifference(sunsetTime, sunriseTime);
            TimeSpan timeSinceSunset = CalculateTimeDifference(sunsetTime, currentTime.TimeOfDay);

            double percentage = timeSinceSunset.TotalMinutes / sunsetToSunriseDuration.TotalMinutes;
            sunLightRotation = Mathf.Lerp(180, 360, (float)percentage);
        }

        sunLight.transform.rotation = Quaternion.AngleAxis(sunLightRotation, Vector3.right);
    }
}
