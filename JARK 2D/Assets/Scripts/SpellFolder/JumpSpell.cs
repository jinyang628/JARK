using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class JumpSpell : Spell
{
    void Awake()
    {
        Name = "CITRINITAS";
        Desc = "Gravity spell. Reduces the gravity on the caster.";
        MpCost = 1;
        AffinityCost = (1, 1); 
    }

    public override void Activate(GameObject parent)
    {

    }
}
