using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReachedChest : MonoBehaviour
{
    private string sceneName;
    private string nextSceneName;
    private int nextSceneNumber;

    void Start(){
        sceneName = SceneManager.GetActiveScene().name; 
        nextSceneNumber = (sceneName[sceneName.Length - 1] + 1) - '0';
        nextSceneName = "Level " + nextSceneNumber.ToString();
        Debug.Log(nextSceneName);
        //ALL CORRECT
        
    }

    private void OnTriggerEnter2D(Collider2D col){
        Debug.Log("help");
        if (col.gameObject.name == "Player"){
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
