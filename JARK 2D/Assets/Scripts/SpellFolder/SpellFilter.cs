using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellFilter : MonoBehaviour
{
    public bool[] validSpells = new bool[4];
    public Spell[] allSpells ;
    private Spell[] activeSpells = new Spell[4];

    public Spell[] GetActiveSpells() {
        return activeSpells;
    }
    // Awake is called at first launch
    void Awake()
    {
        int y = 0;
        for (int x = 0; x < allSpells.Length; x++) {
            if (validSpells[x]) {
                activeSpells[y] = allSpells[x];
                y++;
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            // if mp and affinity is sufficient
            if (true) {
                // activate
                activeSpells[0].Activate(gameObject);
            } else {
                // alert not enough mp/stability
            }
        } else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            // if mp and affinity is sufficient
            if (true) {
                // activate
                activeSpells[1].Activate(gameObject);
            } else {
                // alert not enough mp/stability
            }
        } else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            // if mp and affinity is sufficient
            if (true) {
                // activate
                activeSpells[2].Activate(gameObject);
            } else {
                // alert not enough mp/stability
            }
        } else if (Input.GetKeyDown(KeyCode.Alpha4)) {
            // if mp and affinity is sufficient
            if (true) {
                // activate
                activeSpells[3].Activate(gameObject);
            } else {
                // alert not enough mp/stability
            }
        }
    }
}
