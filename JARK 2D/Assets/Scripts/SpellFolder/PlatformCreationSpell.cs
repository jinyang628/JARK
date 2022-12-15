using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlatformCreationSpell : Spell
{
    public GameObject platformPreFab;
    public AudioSource platformCastSound;

    void Awake()
    {
        Name = "ALBEDO";
        Desc = "Creation spell. Creates a layer of dust underneath the caster.";
        MpCost = 1;
        AffinityCost = (1, 1); 
    }

    public override void Activate(GameObject parent)
    {
        float platformXCoord = parent.transform.position.x - 0.5f;
        float platformYCoord = parent.transform.position.y - 1f;
        // platformCastSound.Play();
        GameObject instantiatedPlatform = Instantiate(platformPreFab, new Vector2(platformXCoord, platformYCoord), Quaternion.identity);
    }
}
