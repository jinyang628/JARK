using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public AudioSource clickAudio;
    public AudioSource hoverAudio;

    public void LoadLevelSelection(){
        SceneManager.LoadScene("LevelSelection");
    }


    public void buttonClickSound()
    {
         clickAudio.Play();
    }

    public void buttonHoverSound()
    {
        hoverAudio.Play();
    }
}
    