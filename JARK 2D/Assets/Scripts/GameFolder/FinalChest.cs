using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalChest : MonoBehaviour
{
    public AudioSource reachedChestSound;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            reachedChestSound.Play();
            StartCoroutine(Wait());
            //PlayerPrefs.SetInt("LevelPassed", nextSceneNumber - 1);
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds((float)0.5);
        SceneManager.LoadScene("WinScene");
    }
}
