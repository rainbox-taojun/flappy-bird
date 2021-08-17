using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<PlayerCharacter>() != null)
		{
			GameMode.instance.ScoreUp();
		}
	}
}
