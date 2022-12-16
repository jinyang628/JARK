using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AWScript : MonoBehaviour
{
    public GameObject Heart;
    public GameObject Background;
    public GameObject StabilityZone;
    public int CurrentQuadrant;
    private PlayerStats player;

    // Resets heart to centre of wheel
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerStats>();
        ResetHeart();
    }
    public void ResetHeart()
    {
        Heart.transform.position = Background.transform.position;
    }

    // Stability changes (scuffed)
    public void IncreaseStability()
    {
        if (StabilityZone.transform.localScale.x < Background.transform.localScale.x)
        {
            StabilityZone.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }           
    }

    public void DecreaseStability()
    {
        if (StabilityZone.transform.localScale.x > 0.6)
        {
            StabilityZone.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }
            
    }

    public void PointerUpdate()
    {
        float x = Heart.transform.position.x - Background.transform.position.x;
        float y = Heart.transform.position.y - Background.transform.position.y;
        
        if (x < 0 && y >= 0)
        {
            CurrentQuadrant = 1;
        }
        else if (x >= 0 && y >= 0)
        {
            CurrentQuadrant = 2;
        }
        else if (x >= 0 && y < 0)
        {
            CurrentQuadrant = 3;
        }
        else
        {
            CurrentQuadrant = 4;
        }
    }
    public bool Stability => (Heart.transform.position - Background.transform.position).magnitude <= StabilityZone.GetComponent<Collider2D>().bounds.size.x / 2;

    // Update pointer position according to PlayerStats
    private void UpdateWheel()
    {
        Vector3 currPosition = Background.transform.position;
        Vector3 newPosition = currPosition + new Vector3(player.GetCurrAffinity().x * 0.5f, player.GetCurrAffinity().y * 0.5f, 0);
        if ((newPosition - Background.transform.position).magnitude <= Background.GetComponent<Collider2D>().bounds.size.x / 2)
        {
            Heart.transform.position = newPosition;
        }
        else
        {
            Vector3 correction = (newPosition - Background.transform.position).normalized;
            Heart.transform.position = Background.transform.position + correction * Background.GetComponent<Collider2D>().bounds.size.x / 2;
        }
    }
    

    void Update()
    { 
        UpdateWheel();
    }


}
