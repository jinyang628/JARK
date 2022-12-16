using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class JumpSpell : Spell
{
    public float change = 1f;
    private AudioSource sound;
    private string directory = "JumpBuffSpellSound";
    void Awake()
    {
        sound = GameObject.Find(directory).GetComponent<AudioSource>();
        Name = "CITRINITAS";
        Desc = "Gravity spell. Reduces the gravity on the caster.";
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
