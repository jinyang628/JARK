using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#jinyang is here;
// kyriel
public class Spells : MonoBehaviour
{
    //alvin comment
    //ROYDENS COMMENT
    public bool[] validSpells = new bool[40];
    private Spell[] allSpells = {
                                new Spell("jalvination", "testy1"),
                                new Spell("prejinyangite", "testy2"),
                                new Spell("valkyrielin", "testy3"),
                                new Spell("preroydenization", "testy4")
                                };
    private Spell[] activeSpells = new Spell[40];
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
    public Spell[] GetActiveSpells(){
        return activeSpells;
    }
}
