using UnityEngine;

public class SoundOnTrigger : MonoBehaviour
{
	//Script made by Brandon Foshe
	// Play one shot sound on a specific trigger when player enters

	[SerializeField]
	private AudioClip audioClip;

	private AudioSource audioSource;

	void Start()
	{
		audioSource = GameObject.FindWithTag("Main").GetComponent<AudioSource>();
	}

	public void PlayOneShotSound(){
		audioSource.PlayOneShot(audioClip);
	}

	public void StopOneShotSound(){
		audioSource.Stop();
	}

	private void OnTriggerEnter(Collider col){
		if (col.CompareTag("Main")) // Checks to see if what is colliding is the player
		{
			PlayOneShotSound();
		}
	}

	private void OnTriggerExit(Collider col){
		if (col.CompareTag("Main"))
		{
			StopOneShotSound();
		}
	}
}
