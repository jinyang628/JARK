using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPBarScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int mp_counter;
    public GameObject square1;
    public GameObject square2;
    public GameObject square3;
    public GameObject square4;
    public GameObject square5;

    void Start()
    {
        mp_counter = 5;
    }

    public void CastSpell(){
        mp_counter--;
        if (mp_counter == 4){
            square5.SetActive(false);
        }
        else if (mp_counter == 3){
            square4.SetActive(false);
        }
        else if (mp_counter == 2){
            square3.SetActive(false);
        }
        else if (mp_counter == 1){
            square2.SetActive(false);
        }
        else {
            square1.SetActive(false);
        }
    }
}
