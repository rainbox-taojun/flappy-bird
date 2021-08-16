using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeate : MonoBehaviour
{
    BoxCollider2D groundCollider;
    float groundColliderWidth;

    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundColliderWidth = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundColliderWidth)
		{
            Vector2 offset = new Vector2(groundColliderWidth * 2f, 0);
            transform.position = (Vector2)transform.position + offset;

        }
    }
}
