using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SpeedSpell : Spell
{
    void Awake()
    {
        Name = "RUBEDO";
        Desc = "Time spell. Speeds up the caster's personal time.";
        MpCost = 1;
        AffinityCost = (1, 1); 
    }

    public override void Activate(GameObject parent)
    {

    }
}
