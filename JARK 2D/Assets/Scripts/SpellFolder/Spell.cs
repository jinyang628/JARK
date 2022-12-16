using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : ScriptableObject {
    public string Name;
    public string Desc;
    public float activeTime = 1f;
    public float cooldown;
    public int MpCost;
    public float x;
    public float y;
    public (float x, float y) AffinityCost; // x, y values of offset

    public virtual void Awake() {
        AffinityCost = (x, y);
    }

    public virtual void Activate(GameObject parent) {}
}
