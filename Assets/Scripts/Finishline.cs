using UnityEngine;

public class Finishline : MonoBehaviour, IInteract
{
	public static Finishline instance;
	public bool isFinished;


	private void Awake()
	{
		instance = this;
	}



	private void Start()
	{
		isFinished = false;
	}

	public void Interact()
	{
		isFinished = true;
	}



}
