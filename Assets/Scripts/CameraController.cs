using UnityEngine;



public class CameraController : MonoBehaviour
{

	[SerializeField] private Transform target;
	[SerializeField] private Vector3 offSet;
	[SerializeField] private Camera cam;
	private Vector3 desiderPos;

	void FixedUpdate()
	{
		desiderPos = target.position + offSet;
		cam.transform.position = Vector3.Lerp(transform.position, desiderPos, 0.2f);
	}
}
