using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerCharacter character;

    void Start()
    {
        character = FindObjectOfType<PlayerCharacter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!character.GetAliveState()) return;

        if (Input.GetMouseButtonDown(0))
		{
            character.Fly();
        }
    }
}
