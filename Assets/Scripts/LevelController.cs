using UnityEngine;
using DG.Tweening;

public class LevelController : MonoBehaviour
{
	public void Rotate(LevelRotater levelRotater)
	{
		transform.SetParent(levelRotater.transform);

		if (levelRotater.Rotate == RotateDecider.right)
		{
			levelRotater.transform.DORotate(new Vector3(0, -45, 0), 0.1f, RotateMode.Fast).OnComplete(() => this.transform.parent = null);
		}
		if (levelRotater.Rotate==RotateDecider.left)
		{
			levelRotater.transform.DORotate(new Vector3(0, 45, 0), 0.1f, RotateMode.Fast).OnComplete(() => this.transform.parent = null);
		}
	}
}

