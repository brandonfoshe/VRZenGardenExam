using UnityEngine;

public class LanternShowText : MonoBehaviour
{

	// Script written by Brandon Foshe during Exam Hours
	// Uses a global lantern tracker to keep track of number of Lanterns. Decrements on release and shows "Peace!" text

	[SerializeField]
	private GameObject textBox;

	public void ShowText(){
		textBox.SetActive(true);
	}

	public void OnReleaseDecrementTracker(){
		GlobalTracker.DecrementLanterns();
	}
}
