using UnityEngine;
using TMPro;

public class UpdateLanternText : MonoBehaviour
{

	// Script written by Brandon Foshe during Exam Hours
	// Attaches to Lantern Counter display text to update with lantern count, decrementing from 5

	[SerializeField]
	private TextMeshProUGUI textBox;

	void Update(){
		textBox.text = GlobalTracker.UpdateTextLantern();
	}
}
