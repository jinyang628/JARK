using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToGame : MonoBehaviour
{
    public void GameReturn(){
        SceneManager.LoadScene(GameSettings.currentLevel);
    }
}
