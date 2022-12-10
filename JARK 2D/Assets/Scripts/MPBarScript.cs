using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPBarScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int mp_counter;
    void Start()
    {
        mp_counter = 5;
    }

    public void CastSpell(){
        mp_counter--;
    }
}
