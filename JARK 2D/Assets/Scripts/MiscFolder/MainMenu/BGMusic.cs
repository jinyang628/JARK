using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    public AudioClip[] songs;
    private int currentSong = 0;
    private static BGMusic instance = null;

    void Awake(){
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
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
