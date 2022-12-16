using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AWScript : MonoBehaviour
{
    public GameObject Heart;
    public GameObject Background;
    public GameObject StabilityZone;
    public float displacementFactor = 0.5f;
    private PlayerStats player;

    // Resets heart to centre of wheel
    void Start()
    {
        player = GameObject.Find("/Player").GetComponent<PlayerStats>();
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

    public bool Stability => (Heart.transform.position - Background.transform.position).magnitude <= StabilityZone.GetComponent<Collider2D>().bounds.size.x / 2;

    // Update pointer position according to PlayerStats
    private void UpdateWheel()
    {
        Vector3 currPosition = Background.transform.position;
        Vector3 newPosition = currPosition + new Vector3(player.GetCurrAffinity().x * displacementFactor, player.GetCurrAffinity().y * displacementFactor, 0);
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
