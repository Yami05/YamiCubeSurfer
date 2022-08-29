using UnityEngine;

public class LevelManager : MonoBehaviour
{
	[SerializeField] private LevelScriptableObjects[] level;

	private void Awake()
	{


		level = Resources.LoadAll<LevelScriptableObjects>("Levels");

		Instantiate(level[PlayerPrefs.GetInt(Utilities.LevelIndex) % level.Length].LevelPrefab);
	}




}
