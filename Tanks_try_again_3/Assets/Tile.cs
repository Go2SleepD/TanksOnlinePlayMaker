using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Tile : MonoBehaviour
{
    public GameObject tilemapGameObject;

    Tilemap tilemap;

    void Start()
    {
        tilemapGameObject = GameObject.FindGameObjectWithTag("Bricks");
        if (tilemapGameObject != null)
        {
            tilemap = tilemapGameObject.GetComponent<Tilemap>();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (tilemap != null && tilemapGameObject == collision.gameObject)
        {
            Vector3 hitPosition = Vector3.zero;
            foreach (ContactPoint2D hit in collision.contacts)
            {
                Debug.Log("YOU SHOT BLOCK");
                hitPosition.x = hit.point.x - 0.01f * hit.normal.x;
                hitPosition.y = hit.point.y - 0.01f * hit.normal.y;
                tilemap.SetTile(tilemap.WorldToCell(hitPosition), null);
            }
        }
    }
}