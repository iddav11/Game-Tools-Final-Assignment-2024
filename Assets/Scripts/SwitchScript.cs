using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public ToggleVision toggleCollisionScript; 
    private bool collisionEnabled = true; 

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            collisionEnabled = !collisionEnabled;
            toggleCollisionScript.ToggleCollisionAndVisibility(collisionEnabled);
        }
    }
}
