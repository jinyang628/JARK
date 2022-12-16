using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyBuffsSpell : MonoBehaviour
{
    public GameObject invisibleFollowerPreFab;
    private GameObject playerObj = null;
    public bool validSpellCast = true;
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
        invisibleFollowerPreFab.transform.position = new Vector3(playerObj.transform.position.x, playerObj.transform.position.y, 0f);

        if (validSpellCast)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                //for input of number 2 on alphanumeric keyboard
                Debug.Log("Key 2:jump buff spell is cast!");
                buffSpellsAnimator.SetTrigger("castJumpSpell");
            }
            
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                //for input of number 3 on alphanumeric keyboard
                Debug.Log("Key 3:speed buff spell is cast!");
                buffSpellsAnimator.SetTrigger("castSpeedSpell");
            }
        }
    }
}
