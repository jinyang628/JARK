using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    void OnEnable()
    {
        int current = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync(current + 1);
    }
}
