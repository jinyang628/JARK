using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell
{
    private string name;
    private string desc;
    public string GetName() {
        return this.name;
    }
    public string GetDesc() {
        return this.desc;
    }
    public Spell(string name, string desc) {
        this.name = name;
        this.desc = desc;
    }
}
