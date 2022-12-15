using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellFilter : MonoBehaviour
{
    public bool[] validSpells = new bool[4];
    public Spell[] allSpells;
    private PlayerStats playerStats;
    KeyCode[] keyCodes = new KeyCode[]
    {
        KeyCode.Alpha1,
        KeyCode.Alpha2,
        KeyCode.Alpha3,
        KeyCode.Alpha4,
    };
    public (Spell[] spells, bool[] active) GetSpells() {
        return (allSpells, validSpells);
    }
    // Awake is called at first launch
    void Awake()
    {
        playerStats = gameObject.GetComponent<PlayerStats>();
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
