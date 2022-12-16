using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSceneMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject previousMusic = GameObject.Find("Music");
        Destroy(previousMusic);
    }
}
