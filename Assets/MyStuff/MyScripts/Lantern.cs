using UnityEngine;

public class Lantern : MonoBehaviour
{

	private bool floatToggle = false;
	[SerializeField]
	float floatSpeed = 1.2f;

	void Update()
	{
		if (floatToggle)
		{
			Float();
		}
	}

	public void Float()
	{
		transform.position += new Vector3(0f, floatSpeed * Time.deltaTime, 0f);
	}

	public void SetFloatToggle(bool val)
	{
		floatToggle = val;
	}
}
