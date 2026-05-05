using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToEndScene : MonoBehaviour
{

	// Script written by Brandon Foshe
	// Goes to ending scene

	public void WhenClicked()
	{
		SceneManager.LoadScene("EndScene");
	}
}
