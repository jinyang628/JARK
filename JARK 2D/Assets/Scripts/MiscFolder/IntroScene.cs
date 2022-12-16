using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    void OnEnable()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait(){
        yield return new WaitForSeconds(2);
        int current = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync(current + 1);
    }
}
