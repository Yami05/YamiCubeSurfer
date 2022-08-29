using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{

	public static StackManager instance;

	private Finishline finishline;
	private GameEvents gameEvents;
	public List<GameObject> cubes = new List<GameObject>();

	private void Awake()
	{
		instance = this;
	}

	void Start()
	{
		gameEvents = GameEvents.instance;
		gameEvents.Stack += GoUp;
		finishline = Finishline.instance;


	}



	private void GoUp()
	{
		for (int i = 1; i < cubes.Count; i++)
		{
			cubes[i].transform.position = new Vector3(cubes[0].transform.position.x, cubes[i - 1].gameObject.transform.position.y + 1, cubes[0].transform.position.z);

		}
	}
	public void GameEndControl()
	{
		if (cubes.Count == 0)
		{
			if (finishline.isFinished == false)
			{
				gameEvents.GameOver?.Invoke();

				return;
			}
			else
			{
				gameEvents.ScoreCal?.Invoke();
				gameEvents.NextLevel?.Invoke();

			}
		}
	}

}
