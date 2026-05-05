using UnityEngine;

public class AnimalEat : MonoBehaviour
{

	// Script written by Brandon Foshe
	// Destroys treat when it comes near the animal

	[SerializeField]
	private AudioClip eating;

	private AudioSource audioSource;

	void Start()
	{
		audioSource = GameObject.FindWithTag("Main").GetComponent<AudioSource>();
	}

	private void OnTriggerEnter(Collider col){
		if(col.CompareTag("Treat")){ // Chescks if the item entering is a treat
									 // If it is, eat it!
			Destroy(col.gameObject);
			audioSource.PlayOneShot(eating);
		}
	}
}
