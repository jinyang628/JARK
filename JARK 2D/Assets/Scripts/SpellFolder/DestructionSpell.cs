using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DestructionSpell : Spell
{
    public GameObject platformPreFab;
    public AudioSource platformCastSound;

    void Awake()
    {
        Name = "NIGREDO";
        Desc = "Destruction spell. Destroys an object near the caster.";
        MpCost = 1;
        AffinityCost = (-1, -1); 
    }

    public override void Activate(GameObject parent)
    {
        float platformXCoord = parent.transform.position.x - 0.5f;
        float platformYCoord = parent.transform.position.y - 1f;
        // platformCastSound.Play();
        GameObject instantiatedPlatform = Instantiate(platformPreFab, new Vector2(platformXCoord, platformYCoord), Quaternion.identity);
    }
}
