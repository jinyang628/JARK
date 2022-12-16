using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlatformCreationSpell : Spell
{
    public GameObject platformPreFab;
    private AudioSource sound;
    private string directory = "PlatformSpellSound";
    void Awake()
    {
        sound = GameObject.Find(directory).GetComponent<AudioSource>();
        Name = "ALBEDO";
        Desc = "Creation spell. Creates a layer of dust underneath the caster.";
    }

    public override void Activate(GameObject parent)
    {
        if (!sound) {
            sound = GameObject.Find(directory).GetComponent<AudioSource>();
        }
        Debug.Log(Name);
        sound.Play();
        float platformXCoord = parent.transform.position.x - 0.5f;
        float platformYCoord = parent.transform.position.y - 1f;
        GameObject instantiatedPlatform = Instantiate(platformPreFab, new Vector2(platformXCoord, platformYCoord), Quaternion.identity);
    }
}
