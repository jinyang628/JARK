using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyPlatformCreation : MonoBehaviour
{
    public GameObject platformPreFab;
    private GameObject playerObj = null;
    public AudioSource platformCastSound;

    void Start()
    {
        if (playerObj == null)
        {
            playerObj = GameObject.Find("Player");
        }
    }

    void Update()
    {
        float platformXCoord = playerObj.transform.position.x - 0.5f;
        float platformYCoord = playerObj.transform.position.y - 1f;

        if (Input.GetKeyDown(KeyCode.F))
        {
            platformCastSound.Play();
            GameObject instantiatedPlatform = Instantiate(platformPreFab, new Vector2(platformXCoord, platformYCoord), Quaternion.identity);
        }
    }
}