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
    public GameObject[] squares;
    void Awake() {

    }
    void Start()
    {
        player = GameObject.Find("/Player").GetComponent<PlayerStats>();
    }

    void Update() {
        int x;
        for (x = 0; x < player.GetCurrMP(); x++) {
            squares[x].SetActive(true);
        }
        for (;x < 5; x++) {
            squares[x].SetActive(false);
        }
    }
}
