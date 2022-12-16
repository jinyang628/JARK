using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReachedChest : MonoBehaviour
{
    private string sceneName;
    private string nextSceneName;
    private int nextSceneNumber;
    public AudioSource reachedChestSound;

    void Start(){
        sceneName = SceneManager.GetActiveScene().name; 
        nextSceneNumber = (sceneName[sceneName.Length - 1] + 1) - '0';
        nextSceneName = "Level " + nextSceneNumber.ToString();
        //ALL CORRECT
        
    }

    private void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.name == "Player"){
            reachedChestSound.Play();
            StartCoroutine(Wait());
            PlayerPrefs.SetInt("LevelPassed", nextSceneNumber - 1);
        }
    }

    IEnumerator Wait(){
        yield return new WaitForSeconds((float)0.5);
        SceneManager.LoadScene(nextSceneName);
    }
}
