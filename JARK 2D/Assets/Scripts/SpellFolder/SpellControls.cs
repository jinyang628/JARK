using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellControls : MonoBehaviour
{
    public Spell spell;

    public KeyCode key;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key)) {
            // if mp and affinity is sufficient
            if (true) {
                // activate
                spell.Activate(gameObject);
            } else {
                // alert not enough mp/stability
            }
        }
    }
}
