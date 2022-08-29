using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class LevelProgress : MonoBehaviour
{
	private GameEvents gameEvents;
	private Finishline finishline;
	[SerializeField] private GameObject player;
	[SerializeField] private TextMeshProUGUI levelText;
	[SerializeField] private Image fillImage;
	private float startDis;

	void Start()
	{
		finishline = Finishline.instance;
		gameEvents = GameEvents.instance;
		gameEvents.NextLevel += () => levelText.text = PlayerPrefs.GetInt(Utilities.LevelIndex).ToString();
		levelText.text = PlayerPrefs.GetInt(Utilities.LevelIndex).ToString();
		startDis = Vector3.Distance(player.transform.position, finishline.transform.position);
	}

	private void Update()
	{
		DistanceCheck();
	}

	private void DistanceCheck()
	{
		float dis = Vector3.Distance(finishline.transform.position, player.transform.position);
		fillImage.fillAmount = dis / startDis;
	}

}
