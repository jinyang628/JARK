using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuMusic : MonoBehaviour
{
    // Update is called once per frame
    void Awake(){
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name.Substring(0, 6) == "Level "){
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().name == "StartMenu"){
            GameObject music = GameObject.Find("Music");
            if (music != null){
                Destroy(music);
            }
        }
    }
}
