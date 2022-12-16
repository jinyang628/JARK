using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellBook : MonoBehaviour
{
    private bool opened;
    public GameObject spellBook;
    public Text leftPage;
    public GameObject player;
    private (Spell[] spells, bool[] active) spellList;
    public Button btn = null;

    void Awake()
    {
        if (!btn) {
            btn = GameObject.Find("/UI/Spellbook").GetComponent<Button>();
        }
        btn.onClick.AddListener(flip);
        player = GameObject.Find("/Player");
        spellList = player.GetComponent<SpellFilter>().GetSpells();
        opened = false;
        leftPage.text = "";
        for (int x = 0; x < spellList.spells.Length; x++) {
            leftPage.text = leftPage.text + spellList.spells[x].Name + " - " + (spellList.active[x] ? "ACTIVE" : "INACTIVE") + "\n" + spellList.spells[x].Desc + "\n";
        }
        Close();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            flip();
        }
    }

    void flip() {
        opened = !opened;
        if (opened)
            Open();
        else
            Close();
    }

    void Open()
    {
        Time.timeScale = 0;
        spellBook.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void Close()
    {
        Time.timeScale = 1;
        spellBook.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}