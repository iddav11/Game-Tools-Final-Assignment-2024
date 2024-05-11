using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Events : MonoBehaviour
{
    public UnityEvent enteredTrigger, exitedTrigger, stayInTrigger;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            enteredTrigger.Invoke();
        }

    }
    // On Trigger stay
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            stayInTrigger.Invoke();
        }

    }
    // On Trigger exit
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            exitedTrigger.Invoke();
        }
    }
}
