using UnityEngine;
using DG.Tweening;
public class CoinManager : MonoBehaviour, ICoin
{
	private GameEvents gameEvents;
	private ScoreManager scoreManager;


	private void Start()
	{
		scoreManager = ScoreManager.instance;
		gameEvents = GameEvents.instance;

		transform.DORotate(new Vector3(0, 360, 0), 2f, RotateMode.FastBeyond360).SetRelative(true).SetEase(Ease.Linear).SetLoops(-1);

	}
	public void CoinInteract()
	{
		gameEvents.Coin?.Invoke();
		scoreManager.coin++;
		DOTween.Kill(transform);
		Destroy(gameObject);


	}
}
