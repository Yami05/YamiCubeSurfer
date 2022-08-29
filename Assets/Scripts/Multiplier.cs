using TMPro;
using UnityEngine;

public class Multiplier : MonoBehaviour
{
	private Material material;
	[SerializeField] private ColorDecider colorDecider;
	private TextMeshPro score;
	private int a;


	private ScoreManager scoreManager;

	private void Start()
	{
		scoreManager = ScoreManager.instance;


		score = GetComponentInChildren<TextMeshPro>();
		material = GetComponent<MeshRenderer>().material;
		colorDecider = (ColorDecider)Random.Range(0, 4);
		ColorDecid();
		score.text = "X" + a.ToString();
	}



	private void ColorDecid()
	{
		switch (colorDecider)
		{
			case global::ColorDecider.red:
				material.color = Color.red;
				a = 3;
				break;
			case global::ColorDecider.green:
				material.color = Color.green;
				a = 4;
				break;
			case global::ColorDecider.blue:
				material.color = Color.blue;
				a = 2;
				break;
			case global::ColorDecider.purple: //xd
				material.color = Color.cyan;
				a = 1;
				break;
			default:
				break;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		other.GetComponent<IObstacle>()?.ObstacleInteract();
		SetScore();
	}

	private void SetScore()
	{

		scoreManager.score = a;

	}


}
