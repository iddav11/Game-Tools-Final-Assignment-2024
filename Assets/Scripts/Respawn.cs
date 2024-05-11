using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public Vector3 spawnPoint;
    public Transform spawnPoint1, spawnPoint2, spawnPoint3, spawnPoint4;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
            transform.position = spawnPoint;
        }
         if(collision.gameObject.CompareTag("Respawn"))
        {
        spawnPoint = spawnPoint1.position;
        transform.position = spawnPoint;
        print ("Im useful");
        }
        if(collision.gameObject.CompareTag("Respawn1"))
        {
        spawnPoint = spawnPoint2.position;
        transform.position = spawnPoint;
        print ("Im useful");
        }
        if(collision.gameObject.CompareTag("Respawn2"))
        {
        spawnPoint = spawnPoint3.position;
        transform.position = spawnPoint;
        print ("Im useful");
        }
        if(collision.gameObject.CompareTag("Respawn3"))
        {
        spawnPoint = spawnPoint4.position;
        transform.position = spawnPoint;
        print ("Im useful");
        }
        if(collision.gameObject.CompareTag("RespawnF"))
        {
        SceneManager.UnloadSceneAsync("Tutorial");
        SceneManager.LoadScene("Level 1");
        print ("Im useful");
        }
        if(collision.gameObject.CompareTag("RespawnF1"))
        {
        SceneManager.UnloadSceneAsync("Tutorial");
        SceneManager.LoadScene("Level 2");
        print ("Im useful");
        }
        if(collision.gameObject.CompareTag("RespawnF2"))
        {
        SceneManager.UnloadSceneAsync("Level 2");
        SceneManager.LoadScene("Level 3");
        print ("Im useful");
        }


    }



    public void advance()
    {

    }
}
