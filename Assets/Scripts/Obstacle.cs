using UnityEngine;

public class Obstacle : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		collision.gameObject.GetComponent<IObstacle>()?.ObstacleInteract();
	}
}
