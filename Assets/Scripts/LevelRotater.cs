using UnityEngine;

public class LevelRotater : MonoBehaviour, IInteract
{
	private LevelController levelController;


	[SerializeField] private RotateDecider rotate;

	public RotateDecider Rotate { get => rotate; set => rotate = value; }


	private void Start()
	{
		levelController = GetComponentInParent<LevelController>();
	}
	public void Interact()
	{
		transform.parent = null;
		levelController.Rotate(this);

	}
}
