using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    public GameObject potionObj;
    private float floatingSpeed = 1.0f;
    private float amplitude = 0.1f;
    private float y_init;
    [SerializeField] GameObject player;
    PlayerStats playerStats;
 
    void Awake()
    {
        playerStats = player.GetComponent<PlayerStats>();
    }

    // Start is called before the first frame update
    void Start()
    {
        y_init = potionObj.transform.position.y;
    }

    //using the playerStats script to update MP value
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            playerStats.SetCurrMP(5);
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //for the floating animation of the potion
        float delta = amplitude * Mathf.Sin(floatingSpeed * Time.time);
        potionObj.transform.position = new Vector3(potionObj.transform.position.x, y_init + delta, 0f);
    }
}
