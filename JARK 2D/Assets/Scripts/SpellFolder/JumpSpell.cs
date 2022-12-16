using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class JumpSpell : Spell
{
    public float change = 1f;
    private AudioSource sound;
    private string directory = "SpellSounds/JumpBuffSpellSound";
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
        var movement = parent.GetComponent<PlayerMovement>();
        movement.jumpingPower += change;
        movement.speed = Mathf.Max(0, movement.speed - change);
    }
}
