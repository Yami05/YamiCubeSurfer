using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
	public static GameEvents instance;

	private void Awake()
	{
		instance = this;
	}



	public Action Stack;
	public Action<Collision> Obstacle;
	public Action<Collision> Lava;
	public Action Coin;
	public Action NextLevel;
	public Action GameOver;
	public Action Start;
	public Action isFinished;
	public Action ScoreCal;
}
