using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellFilter : MonoBehaviour
{
    public bool[] validSpells = new bool[4];
    public Spell[] allSpells ;
    private Spell[] activeSpells = new Spell[4];
    private PlayerStats playerStats;
    KeyCode[] keyCodes = new KeyCode[]
    {
        KeyCode.Alpha1,
        KeyCode.Alpha2,
        KeyCode.Alpha3,
        KeyCode.Alpha4,
    };
    public Spell[] GetActiveSpells() {
        return activeSpells;
    }
    // Awake is called at first launch
    void Awake()
    {
        playerStats = gameObject.GetComponent<PlayerStats>();
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
        for (int x = 0; x < keyCodes.Length; x++) {
            if (Input.GetKeyDown(keyCodes[x])) {
                if (playerStats.affinityIsStable() && playerStats.GetCurrMP() >= allSpells[x].MpCost) {
                    allSpells[x].Activate(gameObject);
                    playerStats.UpdateCurrAffinity(allSpells[x].AffinityCost);
                    playerStats.UpdateCurrMP(allSpells[x].MpCost);
                } else {
                    Debug.Log("Out of MP/unstable affinity");
                }
            }
        }
    }
}
