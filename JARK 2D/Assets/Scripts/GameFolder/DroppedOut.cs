using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DroppedOut : MonoBehaviour
{
    private string sceneName;

    void Start(){
        sceneName = SceneManager.GetActiveScene().name; 
    }

    private void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.name == "Player"){
            SceneManager.LoadScene(sceneName);
        }
    }
}
