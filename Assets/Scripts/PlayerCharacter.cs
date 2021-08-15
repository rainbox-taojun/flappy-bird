using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
	Rigidbody2D rigid;
	Animator animator;

	public float speed;
	public float flyForce;

	bool isAlive; // 存活状态 true活 false死
	bool isFlying; // 是否处于向上飞的状态

	private void Awake()
	{
		rigid = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();

		isAlive = true;
	}

	public bool GetAliveState()
	{
		return isAlive;
	}

	// 飞
	public void Fly()
	{
		animator.SetTrigger("Fly");

		rigid.velocity = Vector2.zero;
		rigid.AddForce(new Vector2(0, flyForce));
	}

	// 死亡
	public void Die()
	{
		isAlive = false;
		animator.SetTrigger("Die");
		rigid.velocity = Vector2.zero;
		GameMode.instance.GameOver();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Die();
	}
}
