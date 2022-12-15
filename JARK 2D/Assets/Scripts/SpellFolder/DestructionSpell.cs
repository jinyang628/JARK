using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DestructionSpell : Spell
{
    void Awake()
    {
        Name = "NIGREDO";
        Desc = "Destruction spell. Destroys an object near the caster.";
        MpCost = 1;
        AffinityCost = (-1, -1); 
    }

    public override void Activate(GameObject parent)
    {
        Debug.Log(Name);
    }
}
