using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DestructionSpell : Spell
{
    private AudioSource sound;
    private string directory = "DestroySpellSound";
    void Awake()
    {
        sound = GameObject.Find(directory).GetComponent<AudioSource>();
        Desc = "Destruction spell. Destroys an object near the caster.";
        MpCost = 1;
        AffinityCost = (-1, -1); 
    }

    public override void Activate(GameObject parent)
    {
        if (!sound) {
            sound = GameObject.Find(directory).GetComponent<AudioSource>();
        }
        Debug.Log(Name);
        sound.Play();
    }
}
