using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    public AudioClip[] songs;
    private int currentSong = 0;

    void Awake(){
        DontDestroyOnLoad(this.gameObject);
    }

    void Update ()
    {
        if (GetComponent<AudioSource>().isPlaying == false)
        {
            currentSong++;
            if (currentSong >= songs.Length)
            {
                currentSong = 0;            
            }
            GetComponent<AudioSource>().clip = songs[currentSong];
            GetComponent<AudioSource>().Play();
        }
    }
}
