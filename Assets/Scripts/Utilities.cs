using UnityEngine;

public enum RotateDecider
{
	right,
	left,
}

public enum ColorDecider
{
	red,
	green,
	blue,
	purple
}

public static class Utilities
{


	public const string LevelIndex = "LevelIndex";
	public static void SetLevelPref(int levelCount = 1)
	{
		PlayerPrefs.SetInt(LevelIndex, PlayerPrefs.GetInt(LevelIndex, 1) + levelCount);

	}


	public const string CoinCount = "CoinCount";
	public static void IncrementCoin(int count)
	{
		PlayerPrefs.SetInt(CoinCount, PlayerPrefs.GetInt(CoinCount, 0) + count);

	}
}
