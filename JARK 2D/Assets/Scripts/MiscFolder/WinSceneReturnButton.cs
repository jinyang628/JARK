using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneReturnButton : MonoBehaviour
{
    public void ReturnToStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
