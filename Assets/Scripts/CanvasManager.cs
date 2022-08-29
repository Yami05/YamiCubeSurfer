using TMPro;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
	private GameEvents gameEvents;

	[SerializeField] private TextMeshProUGUI coinText;

	private void Start()
	{
		coinText.text = PlayerPrefs.GetInt(Utilities.CoinCount).ToString();
		gameEvents = GameEvents.instance;
		gameEvents.Coin = () => coinText.text = PlayerPrefs.GetInt(Utilities.CoinCount).ToString();
	}


}
