using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SpeedSpell : Spell
{
    public float change = 2f;
    private AudioSource sound;
    private string directory = "SpeedBuffSpellSound";
    void Awake()
    {
        sound = GameObject.Find(directory).GetComponent<AudioSource>();
        Name = "RUBEDO";
        Desc = "Time spell. Speeds up the caster's personal time.";
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
        movement.speed += change;
        movement.jumpingPower -= change;
    }
}
