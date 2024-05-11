using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSection : MonoBehaviour
{
    public Vector3 spawnPoint;
    public Vector3 newSpawnPoint;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
            transform.position = newSpawnPoint;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = newSpawnPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
