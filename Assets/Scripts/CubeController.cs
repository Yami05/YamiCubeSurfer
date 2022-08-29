using UnityEngine;
public class CubeController : MonoBehaviour, IInteract, IObstacle
{
	private StackManager stackManager;
	private GameEvents gameEvents;
	private BoxCollider boxCollider;
	private Rigidbody rb;
	void Start()
	{
		stackManager = StackManager.instance;
		gameEvents = GameEvents.instance;
		boxCollider = GetComponent<BoxCollider>();
	}


	public void Interact()
	{
		rb = gameObject.AddComponent<Rigidbody>();
		boxCollider.isTrigger = false;
		rb.constraints = RigidbodyConstraints.FreezeAll;
		rb.constraints = ~RigidbodyConstraints.FreezePositionY;
		stackManager.cubes.Add(gameObject);
		transform.SetParent(stackManager.transform);
		gameEvents.Stack?.Invoke();
	}
	public void ObstacleInteract()
	{
		transform.SetParent(null);
		stackManager.cubes.Remove(gameObject);

		stackManager.GameEndControl();



		Destroy(gameObject, 0.5f);


	}

	private void OnTriggerEnter(Collider other)
	{
		other.GetComponent<ICoin>()?.CoinInteract();
	}
}