using UnityEngine;
using TMPro;

public class UpdateSphereText : MonoBehaviour
{

	// Script written by Brandon Foshe during Exam Hours
	// Attaches to Sphere thrown display to show number of spheres thrown, simimlar to lanters

	[SerializeField]
	private TextMeshProUGUI textBox;

	void Update(){
		textBox.text = GlobalTracker.UpdateTextSphere();
	}
}
