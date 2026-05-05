using UnityEngine;

public class Button : MonoBehaviour
{

	/// <summary>
	/// BUTTON command On Press summons a serialized object with a random spawn range
	/// </summary>
	[SerializeField]
	GameObject itemToTrigger;
	[SerializeField]
	Transform initialSpawn;

	private float randomness = 0.5f;

	// Trigger action
	public void OnPress()
	{
		// Do ACTION
		// set random spawn
		Vector3 randomOffset = new Vector3(Random.Range(-randomness, randomness), 0, Random.Range(-randomness, randomness));
		// spawn
		GameObject newCoin = Instantiate(itemToTrigger, initialSpawn.position + randomOffset, this.transform.rotation);
	}

	public void Unpress()
	{

	}
}
