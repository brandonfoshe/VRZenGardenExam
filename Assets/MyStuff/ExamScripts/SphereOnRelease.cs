using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class SphereOnRelease : MonoBehaviour
{

	// Script written by Brandon Foshe during Exam Hours
	// Calls method on release of sphere, disable sphere
	// Sphere updates sphere thrown counter and displays message from list

	[SerializeField]
	private TextMeshProUGUI textBox;
	[SerializeField]
	private GameObject canvasDisplay, parentItem;
	[SerializeField]
	private Transform displayHolder;
	private static int i = 0; // Tracker for message

	List<string> messages = new List<string>() {
		"Great job throwing that sphere!",
		"Poof!",
		"Hello!",
		"Are you feeling Zen?",
		"I'm the sphere and that wasn't very nice",
	};

	public void OnRelease(){
		// Increment spheres thrown
		GlobalTracker.IncrementSpheres();
		// Show text canvas game object
		canvasDisplay.SetActive(true);
		// Remove canvas display from its parent so it isn't disable with the sphere
		canvasDisplay.transform.SetParent(displayHolder);
		// Display message
		textBox.text = messages[i];
		i++;
		// Vanish sphere
		parentItem.SetActive(false);
	}
}
