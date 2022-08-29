using UnityEngine;

public class Lava : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<IObstacle>()?.ObstacleInteract();
    }
}
