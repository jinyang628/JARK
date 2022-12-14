using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSettings : MonoBehaviour
{
    public static string currentLevel;

    public void openSettingsMenu(){
        SceneManager.LoadScene("PauseMenu");
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("PauseMenu");
        }
        currentLevel = SceneManager.GetActiveScene().name;
        Debug.Log(currentLevel);
    }

}
