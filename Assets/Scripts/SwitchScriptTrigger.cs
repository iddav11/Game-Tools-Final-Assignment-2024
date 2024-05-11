using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScriptTrigger: MonoBehaviour
{
    public ToggleVision toggleCollisionScript; 
    private bool collisionEnabled = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                collisionEnabled = !collisionEnabled;
                toggleCollisionScript.ToggleCollisionAndVisibility(collisionEnabled);
            }
        }
    }
}
