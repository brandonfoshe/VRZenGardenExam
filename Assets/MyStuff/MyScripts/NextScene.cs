using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{

	// Script written by Brandon Foshe
	// Goes to the main scene from the intro scene

	public void WhenClicked(){
		SceneManager.LoadScene("MainZenGarden");
	}
}
