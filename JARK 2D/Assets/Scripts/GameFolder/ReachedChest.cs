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
        nextSceneNumber = sceneName[sceneName.Length - 1] + 1;
        nextSceneName = "Level " + nextSceneNumber.ToString();
        Debug.Log(nextSceneName);
        
        
    }
    //void OnCollisionEnter
    void OnTriggerEnter(Collider col){
        Debug.Log("here");
        if (col.GetComponent<Collider>().name == "Player"){
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
