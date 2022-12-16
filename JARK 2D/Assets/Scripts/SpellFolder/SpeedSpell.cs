using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SpeedSpell : Spell
{
    public float change = 1f;
    private AudioSource sound;
    private string directory = "SpellSounds/SpeedBuffSpellSound";
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
        movement.speed += change;
        movement.jumpingPower = Mathf.Max(0, movement.jumpingPower - change);
    }
}
