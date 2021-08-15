using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(GameMode.instance.scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameMode.instance.gameOver)
		{
            rigid.velocity = Vector2.zero;
		}
    }
}
