using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript7sec : MonoBehaviour
{
    public ToggleVision toggleCollisionScript; 
    private bool collisionEnabled = true; 
    //public float remainingtime, initialTime;
    private float timerSpeed = 2f;
    private float lastTimestamp;
    public float time;


    void Start()
    {
        //remainingtime = initialTime;
    }

   void update()
   {
    time = Time.deltaTime;
        if (Time.time - lastTimestamp >= timerSpeed)
        {
            {
                lastTimestamp = Time.time;
                collisionEnabled = !collisionEnabled;
                
                toggleCollisionScript.ToggleCollisionAndVisibility(collisionEnabled);
                Debug.Log("Working");
            
            }
        }
   }

    // IEnumerator ToggleEverySevenSeconds()
    // {
   
        
    //     while (true)
    //     {
    //         collisionEnabled = !collisionEnabled;
            
    //         toggleCollisionScript.ToggleCollisionAndVisibility(collisionEnabled);
            
    //         yield return new WaitForSeconds(7f);

    //         Debug.Log("Working");
    //     }
    // }
}
