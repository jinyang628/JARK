using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : ScriptableObject {
    public string Name {get; set;}
    public string Desc {get; set;}

    public int MpCost {get; set;}
    public (float, float) affinityCost {get; set;} // x, y values of offset
    public virtual void Activate(GameObject parent) {}
}
