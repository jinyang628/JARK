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
        foreach (Spell s in allSpells) {
            s.Awake();
        }
        allSpells[3].cooldown = 0;
    }

    void Update()
    {
        allSpells[3].cooldown = Mathf.Max(0, allSpells[3].cooldown - Time.deltaTime);
        if (allSpells[3].cooldown <= 0) {
            gameObject.tag = "Untagged";
        }
        for (int x = 0; x < keyCodes.Length; x++) {
            if (Input.GetKeyDown(keyCodes[x]) && validSpells[x]) {
                if (playerStats.affinityIsStable() && playerStats.GetCurrMP() >= allSpells[x].MpCost && (x == 3 ? allSpells[x].cooldown == 0 : true)) {
                    Debug.Log("ON, MP - " + playerStats.GetCurrMP() + " COST - " + allSpells[x].MpCost);
                    allSpells[x].Activate(gameObject);
                    playerStats.UpdateCurrAffinity(allSpells[x].AffinityCost);
                    Debug.Log(playerStats.GetCurrAffinity());
                    playerStats.UpdateCurrMP(allSpells[x].MpCost);
                } else {
                    Debug.Log("Out of MP/unstable affinity");
                }
            }
        }
    }
}
