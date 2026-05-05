using UnityEngine;

public class ActivateOnTrigger : MonoBehaviour
{

	//Script written by Brandon Foshe
	// Activate or spawn an item on trigger

	[SerializeField]
	private GameObject itemToTrigger;

	public void Activate()
	{
		itemToTrigger.SetActive(true);
	}

	public void Deactivate()
	{
		itemToTrigger.SetActive(false);
	}

	private void OnTriggerEnter(Collider col)
	{
		if (col.CompareTag("Main"))
		{
			Activate();
		}
	}

	private void OnTriggerExit(Collider col)
	{
		if(col.CompareTag("Main"))
		{
			Deactivate();
		}
	}
}
