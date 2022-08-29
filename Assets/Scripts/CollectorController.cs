using UnityEngine;

public class CollectorController : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		other.GetComponent<IInteract>()?.Interact();
	}
}
