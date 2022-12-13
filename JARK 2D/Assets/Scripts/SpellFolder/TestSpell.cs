using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class TestSpell : Spell
{
    // Start is called before the first frame update
    public override void Activate(GameObject parent)
    {
        // do something
        Debug.Log("i run");
    }
}
