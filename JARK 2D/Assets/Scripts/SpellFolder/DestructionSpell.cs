using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DestructionSpell : Spell
{
    private AudioSource sound;
    private string directory = "SpellSounds/DestroySpellSound";

    public override void Awake()
    {
        base.Awake();
        sound = GameObject.Find(directory).GetComponent<AudioSource>();
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
