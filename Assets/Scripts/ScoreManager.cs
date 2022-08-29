using UnityEngine;

public class ScoreManager : MonoBehaviour
{

	public static ScoreManager instance;
	private GameEvents gameEvents;
	public int coin;

	public int score;

	public int TotalMoney;
	private void Awake()
	{
		instance = this;
	}

	private void Start()
	{
		coin = 0;
		gameEvents = GameEvents.instance;
		gameEvents.ScoreCal += CoinCalulator;
	}

	private void CoinCalulator()
	{
		TotalMoney = score * coin;
		Utilities.IncrementCoin(TotalMoney);

	}
}
