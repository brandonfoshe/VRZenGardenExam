using UnityEngine;

public class PlaySound : MonoBehaviour
{

	//Script made by Brandon Foshe
	// Play one shot sound when activated

	[SerializeField]
	private AudioClip audioClip;

	private AudioSource audioSource;

	void Start(){
		audioSource = GameObject.FindWithTag("Main").GetComponent<AudioSource>();
	}

	public void PlayOneShotSound() {
		audioSource.PlayOneShot(audioClip);
	}

	public void StopSound() {
		audioSource.Stop();
	}
}
