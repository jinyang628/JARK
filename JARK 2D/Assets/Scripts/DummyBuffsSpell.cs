using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyBuffsSpell : MonoBehaviour
{
    public GameObject invisibleFollowerPreFab;
    private GameObject playerObj = null;
    public bool validSpellCast = true;
    public AudioSource jumpSpellSound;
    public AudioSource speedSpellSound;
    public Animator buffSpellsAnimator;

    void Start()
    {
        if (playerObj == null)
        {
            playerObj = GameObject.Find("Player");
        }
    }

    void Update()
    {
        //constantly update invisibleFollower's position to be same as Player's position

        /*
        invisibleFollowerPreFab.transform.position.x = playerObj.transform.position.x;
        invisibleFollowerPreFab.transform.position.y = playerObj.transform.position.y;
        */

        invisibleFollowerPreFab.transform.position = new Vector3(playerObj.transform.position.x, playerObj.transform.position.y, 0f);

        if (validSpellCast)
        {
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                //for input of number 3 on alphanumeric keyboard
                Debug.Log("Key 3:jump buff spell is cast!");
                jumpSpellSound.Play();
                buffSpellsAnimator.SetTrigger("castJumpSpell");
            }
            
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                //for input of number 4 on alphanumeric keyboard
                Debug.Log("Key 4:speed buff spell is cast!");
                speedSpellSound.Play();
                buffSpellsAnimator.SetTrigger("castSpeedSpell");
            }
        }
    }
}
