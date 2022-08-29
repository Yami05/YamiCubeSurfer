using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private GameEvents gameEvents;
	private void Start()
	{
		gameEvents = GameEvents.instance;


	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.N))
		{
			NextLevel();
		}
	}
	public void Retry()
	{
		SceneManager.LoadScene("SampleScene");
	}

	public void StartTheGame()
	{
		gameEvents.Start?.Invoke();
	}

	public void NextLevel()
	{
		Utilities.SetLevelPref();
		SceneManager.LoadScene("SampleScene");
	}
}
