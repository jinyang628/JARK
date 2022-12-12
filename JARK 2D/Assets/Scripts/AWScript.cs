using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AWScript : MonoBehaviour
{
    public GameObject Heart;
    public GameObject Background;
    public GameObject StabilityZone;
    public int CurrentQuadrant;
    public bool IsStable;
    public bool WithinWheel;
 
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
   
    // public bool IsStable => Heart.GetComponent<Collider2D>().bounds.Intersects(StabilityZone.GetComponent<Collider2D>().bounds);
    // public bool WithinWheel => Heart.GetComponent<Collider2D>().bounds.Intersects(Background.GetComponent<Collider2D>().bounds);

    public void PointerUpdate()
    {
        float x = Heart.transform.position.x - Background.transform.position.x;
        float y = Heart.transform.position.y - Background.transform.position.y;
        float displacement = new Vector2(x, y).sqrMagnitude;

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

        if (displacement <= StabilityZone.GetComponent<CircleCollider2D>().radius)
        {
            IsStable = true;
        } else
        {
            IsStable = false;
        }

        if (displacement <= Background.GetComponent<CircleCollider2D>().radius)
        {
            WithinWheel = true;
        } else
        {
            WithinWheel = false;
        }
    }

    void Start()
    {
        ResetHeart();
    }


    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Heart.GetComponent<Rigidbody2D>().velocity = new Vector2(horizontal * 3f, vertical * 3f);
        PointerUpdate();
        Debug.Log("Quadrant: " + CurrentQuadrant + ", Stability: " + IsStable + ", Within: " + WithinWheel);
        
    }


}
