using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSettings : MonoBehaviour
{
    public static string currentLevel;
    public AudioSource escSound;

    void Start(){
        currentLevel = SceneManager.GetActiveScene().name;
    }
    
    public void openSettingsMenu(){
        escSound.Play();
        Time.timeScale = 0;
        SceneManager.LoadScene("PauseMenu");
        GameState.game_paused = true;
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            openSettingsMenu();
        }
    }
}
