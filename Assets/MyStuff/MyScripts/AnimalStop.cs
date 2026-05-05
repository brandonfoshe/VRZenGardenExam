using UnityEngine;

public class AnimalStop : MonoBehaviour
{

	// Script written by Brandon Foshe
	// Stops animal from moving when a player is nearby (so they can pet it)

	[SerializeField]
	private AudioClip animalSound;
	[SerializeField]
	private Animator animator;

	private AudioSource audioSource;

	void Start()
	{
		audioSource = GameObject.FindWithTag("Main").GetComponent<AudioSource>();
		// Start playing animation
		animator.speed = 1;
	}

	private void OnTriggerEnter(Collider col){
		if(col.CompareTag("Main")){ //Only runs when the player enters the trigger zone
			// Pause animation
			animator.speed = 0;
			// Play animal Sound
			audioSource.PlayOneShot(animalSound);
		}
	}

	private void OnTriggerExit(Collider col){
		if (col.CompareTag("Main"))
		{
			// Resume animation
			animator.speed = 1;
		}
	}
}
