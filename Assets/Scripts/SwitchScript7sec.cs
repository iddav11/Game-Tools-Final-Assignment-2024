using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript7sec : MonoBehaviour
{
    public ToggleVision toggleCollisionScript; 
    private bool collisionEnabled = true; 
    public float switchTime = 7f;

    IEnumerator ToggleEverySevenSeconds()
    {
        while (true)
        {
            collisionEnabled = !collisionEnabled;
            
            toggleCollisionScript.ToggleCollisionAndVisibility(collisionEnabled);
            
            yield return new WaitForSeconds(7f);
        }
    }
}
