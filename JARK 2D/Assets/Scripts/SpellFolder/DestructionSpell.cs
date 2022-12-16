using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DestructionSpell : Spell
{
    private AudioSource sound;
    private string directory = "SpellSounds/DestroySpellSound";
    void Awake()
    {
        sound = GameObject.Find(directory).GetComponent<AudioSource>();
        Name = "NIGREDO";
        Desc = "Destruction spell. Destroys an object near the caster.";
    }

    public override void Activate(GameObject parent)
    {
        if (!sound) {
            sound = GameObject.Find(directory).GetComponent<AudioSource>();
        }
        Debug.Log(Name);
        sound.Play();
        parent.tag = "Destroyer";
        cooldown = activeTime;
    }
}
