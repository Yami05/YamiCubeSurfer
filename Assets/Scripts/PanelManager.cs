using TMPro;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
	private GameEvents gameEvents;
	private ScoreManager scoreManager;


	[SerializeField] private GameObject gameOverPanel;
	[SerializeField] private GameObject startPanel;
	[SerializeField] private GameObject nextLevel;
	[SerializeField] private TextMeshProUGUI TotalMoney;
	private void Start()
	{
		gameEvents = GameEvents.instance;
		scoreManager = ScoreManager.instance;

		gameEvents.GameOver += () => gameOverPanel.SetActive(true);
		gameEvents.Start += () => startPanel.SetActive(false);
		gameEvents.NextLevel += () => { nextLevel.SetActive(true); TotalMoney.text = scoreManager.TotalMoney.ToString(); };

	}




}
