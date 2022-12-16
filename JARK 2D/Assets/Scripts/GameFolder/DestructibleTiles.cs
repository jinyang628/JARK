using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DestructibleTiles : MonoBehaviour
{
    public Tilemap tiles;
    // Start is called before the first frame update
    void Start() {
        tiles = gameObject.GetComponent<Tilemap>();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("i hit something" + other.gameObject.tag);
        if (other.gameObject.CompareTag("Destroyer")) {
            Vector3 hitPos = Vector3.zero;
            foreach(ContactPoint2D hit in other.contacts) {
                hitPos.x = hit.point.x - 0.01f * hit.normal.x;
                hitPos.y = hit.point.y - 0.01f * hit.normal.y;
                tiles.SetTile(tiles.WorldToCell(hitPos), null);
            }
        }
    }
}
