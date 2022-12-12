using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellBook : MonoBehaviour
{
private bool opened;
    public GameObject spellBook;
    public Text leftPage;
    public Text rightPage;
    public GameObject spells;
    private Spell[] spellList;
    void Awake()
    {
        spellList = spells.GetComponent<Spells>().GetActiveSpells();
        opened = false;
        leftPage.text = "";
        for (int x = 0; x < spellList.Length; x++) {
            leftPage.text = leftPage.text + spellList[x].GetName() + "\n" + spellList[x].GetDesc() + "\n";
        }
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
