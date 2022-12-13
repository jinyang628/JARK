using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level4Specific : MonoBehaviour
{
    public GameObject words;
    private void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.name == "Player"){
            Destroy(words);
        }
    }
}
