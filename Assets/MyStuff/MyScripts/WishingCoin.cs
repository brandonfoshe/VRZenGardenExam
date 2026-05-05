using UnityEngine;

public class WishingCoin : MonoBehaviour
{
	// Script written by Brandon Foshe
	// Logic for throwing coins into the wishing fountain

	[SerializeField]
	private AudioClip success, error;
	[SerializeField]
	private GameObject copperPrize, silverPrize, goldPrize;
	[SerializeField]
	private Transform spawnLocation;

	private AudioSource audioSource;

	void Start(){
		audioSource = GameObject.FindWithTag("Main").GetComponent<AudioSource>();
	}

	private void OnTriggerEnter(Collider col){
		// Checks what kind of coin entered to give correct prize
		if(col.CompareTag("CopperCoin")){
			//Give Copper prize
			Instantiate(copperPrize, spawnLocation);
			audioSource.PlayOneShot(success);
		}
		else if(col.CompareTag("SilverCoin")){
			//Give Silver prize
			Instantiate(silverPrize, spawnLocation);
			audioSource.PlayOneShot(success);
		}
		else if (col.CompareTag("GoldCoin"))
		{
			//Give Gold prize
			Instantiate(goldPrize, spawnLocation);
			audioSource.PlayOneShot(success);
		}
		else { audioSource.PlayOneShot(error); }
	}
}
