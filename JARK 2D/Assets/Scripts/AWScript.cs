using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AWScript : MonoBehaviour
{
    public GameObject Heart;
    public GameObject Background;
    public GameObject StabilityZone;
 
    // Resets heart to centre of wheel
    public void ResetHeart()
    {
        Heart.transform.position = new Vector2(Background.transform.position.x, Background.transform.position.y);
    }

    // Stability changes are currently hard-coded...
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
   
    public bool IsStable => Heart.GetComponent<Collider2D>().bounds.Intersects(StabilityZone.GetComponent<Collider2D>().bounds);
    public bool WithinWheel => Heart.GetComponent<Collider2D>().bounds.Intersects(Background.GetComponent<Collider2D>().bounds);

    public void helper()
    {
        float WheelRadius = Background.GetComponent<CircleCollider2D>().radius;
        
    }
    
    
    void Start()
    {
        ResetHeart();
    }

    
    
}
