using UnityEngine;

public class ChibiController : MonoBehaviour
{

	private StackManager stackManager;


	private void Start()
	{

		stackManager = StackManager.instance;
	}
	void Update()
	{
		if (stackManager.cubes.Count == 0)
		{
			return;
		}
		transform.position = new Vector3(stackManager.transform.position.x , stackManager.cubes[stackManager.cubes.Count - 1].transform.position.y + 0.6f, stackManager.transform.position.z);
	}

}
