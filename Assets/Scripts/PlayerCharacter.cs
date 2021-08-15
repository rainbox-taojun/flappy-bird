using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
	Rigidbody2D rigid;
	Animator animator;

	public float speed;
	public float flyForce;

	bool isAlive; // ���״̬ true�� false��
	bool isFlying; // �Ƿ������Ϸɵ�״̬

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

	// ��
	public void Fly()
	{
		animator.SetTrigger("Fly");

		rigid.velocity = Vector2.zero;
		rigid.AddForce(new Vector2(0, flyForce));
	}

	// ����
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
