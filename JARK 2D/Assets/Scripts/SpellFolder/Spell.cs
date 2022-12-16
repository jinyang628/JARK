using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : ScriptableObject {
    public string Name {get; set;}
    public string Desc {get; set;}
    public float activeTime = 1f;
    public float cooldown;
    public int MpCost;
    public float x;
    public float y;
    public (float x, float y) AffinityCost; // x, y values of offset
    
    public virtual void Activate(GameObject parent) {}
}
