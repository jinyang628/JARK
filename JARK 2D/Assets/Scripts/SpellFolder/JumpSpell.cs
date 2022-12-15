using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class JumpSpell : Spell
{
    public float change = 2f;
    private AudioSource sound;
    private string directory = "JumpBuffSpellSound";
    void Awake()
    {
        sound = GameObject.Find(directory).GetComponent<AudioSource>();
        Name = "CITRINITAS";
        Desc = "Gravity spell. Reduces the gravity on the caster.";
        MpCost = 1;
        AffinityCost = (1, 1); 
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
        movement.speed -= change;
    }
}
