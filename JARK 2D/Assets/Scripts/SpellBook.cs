using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellBook : MonoBehaviour
{
    private bool opened;
    public GameObject spellBook;
    void Awake()
    {
        opened = false;
        Close();
    }

    void Start()
    {
        opened = false;
        Close();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            opened = !opened;
            if (opened)
                Open();
            else
                Close();
        }
    }

    void Open()
    {
        spellBook.SetActive(true);
        // something to load all the spells
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void Close()
    {
        spellBook.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
