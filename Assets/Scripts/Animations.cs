using UnityEngine;

public class Animations : MonoBehaviour
{
	private GameEvents gameEvents;

	[SerializeField] private Animator animator;
	private void Start()
	{
		gameEvents = GameEvents.instance;
		gameEvents.Start += () => animator.SetBool("Start", true);
		gameEvents.GameOver = () => animator.SetBool("GameOver", true);
		gameEvents.NextLevel = () => animator.SetBool("Win", true);
	}







}
