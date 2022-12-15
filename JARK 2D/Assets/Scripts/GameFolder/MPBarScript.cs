using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPBarScript : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerStats player;
    public GameObject square1;
    public GameObject square2;
    public GameObject square3;
    public GameObject square4;
    public GameObject square5;

    void Start()
    {
        player = GameObject.Find("/Player").GetComponent<PlayerStats>();
    }

    void Update() {
        switch (player.GetCurrMP()) {
            case 5:
                break;
            case 4:
                square5.SetActive(false);
                break;
            case 3:
                square4.SetActive(false);
                break;
            case 2:
                square3.SetActive(false);
                break;
            case 1:
                square2.SetActive(false);
                break;
            case 0:
                square1.SetActive(false);
                break;
        }
    }
}
