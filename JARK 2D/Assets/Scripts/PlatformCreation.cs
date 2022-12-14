using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCreation : MonoBehaviour
{
    public GameObject platformPreFab;
    public GameObject player;

    void Update()
    {
        private Vector2 platformCoords = (player.transform.position.x - 1f, player.transform.position.y);

        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject instantiatedPlatform = Instantiate(platformPreFab, platformCoords);
        }
    }
}
