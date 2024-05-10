using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ToggleVision : MonoBehaviour
{
    private Collider2D myCollider; 
    //private SpriteRenderer mySpriteRenderer; 
    private Tilemap myTM;
    private TilemapRenderer myTileR;

    void Start()
    {
        myCollider = GetComponent<Collider2D>();
        
        //ySpriteRenderer = GetComponent<SpriteRenderer>();

        myTM = GetComponent<Tilemap>();

        myTileR = GetComponent<TilemapRenderer>();
    }


    public void ToggleCollisionAndVisibility(bool enableCollision)
    {
        myCollider.isTrigger = !enableCollision;
        
        //mySpriteRenderer.enabled = enableCollision;

        myTM.enabled = enableCollision;
        myTileR.enabled = enableCollision;
    }
}
