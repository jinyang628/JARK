using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DestructionSpell : Spell
{
    public float destructionDist = 5f;
    private AudioSource sound;
    private string directory = "DestroySpellSound";
    void Awake()
    {
        sound = GameObject.Find(directory).GetComponent<AudioSource>();
        Name = "NIGREDO";
        Desc = "Destruction spell. Destroys an object near the caster.";
    }

    public override void Activate(GameObject parent)
    {
        GameObject ClosestTaggedObject(string tag)
        {
            GameObject[] gos;
            gos = GameObject.FindGameObjectsWithTag(tag);
            GameObject closest = null;
            float distance = Mathf.Infinity;
            Vector3 position = parent.transform.position;
            foreach (GameObject go in gos)
            {
                Vector3 diff = go.transform.position - position;
                float curDistance = diff.sqrMagnitude;
                if (curDistance < distance)
                {
                    closest = go;
                    distance = curDistance;
                }
            }
            return closest;
        }        
        if (!sound) {
            sound = GameObject.Find(directory).GetComponent<AudioSource>();
        }
        Debug.Log(Name);
        GameObject closest = ClosestTaggedObject("Destructible");
        if (closest && (parent.transform.position - closest.transform.position).sqrMagnitude < destructionDist) {
            sound.Play();
            Destroy(closest);
        } else {
            Debug.Log("No destructible objects in range");
        }
    }
}
