using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private GameEvents gameEvents;


	[SerializeField] private float speed;
	[SerializeField] Camera cam;
	private Vector3 firstClick;
	private Vector3 lastClick;
	private Vector3 diff;

	private bool canMove;

	[SerializeField] private float sens;




	private void Start()
	{
		gameEvents = GameEvents.instance;
		gameEvents.Start += () =>
		{
			canMove = true;
			gameEvents.GameOver += () => canMove = false;
			gameEvents.NextLevel += () => canMove = false;
		};

	}



	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			OnMouseClick();
		}
		if (Input.GetMouseButton(0))
		{
			OnMouseHold();
		}
		if (Input.GetMouseButtonUp(0))
		{
			OnMouseUp();
		}
	}

	void FixedUpdate()
	{


		MoveForward();

	}

	private void MoveForward()
	{
		if (canMove == true)
		{
			transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + diff.x, transform.position.y, transform.position.z + speed), 0.02f);

			//rb.velocity = Vector3.Lerp(rb.velocity, new Vector3(diff.x * 4, rb.velocity.y, 15), 0.2f);
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4, 4), transform.position.y, transform.position.z);
		}
	}


	private void OnMouseClick()
	{
		firstClick = cam.ScreenToWorldPoint(Input.mousePosition);
		lastClick = firstClick;
	}


	private void OnMouseHold()
	{
		lastClick = cam.ScreenToWorldPoint(Input.mousePosition);
		diff = lastClick - firstClick;
		diff *= sens;
	}

	private void OnMouseUp()
	{
		diff.x = 0;
		firstClick.x = 0;
		lastClick.x = 0;
	}


}
