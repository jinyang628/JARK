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
    private bool WithinWheel;

 
    // Resets heart to centre of wheel
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
        float displacement = (Heart.transform.position - Background.transform.position).magnitude;


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

        
        if (displacement <= StabilityZone.GetComponent<Renderer>().bounds.size.x / 2)
        {
            IsStable = true;
        } else
        {
            IsStable = false;
        }
        

        if (displacement <= Background.GetComponent<Renderer>().bounds.size.x / 2)
        {
            WithinWheel = true;
        } else
        {
            WithinWheel = false;
        }
        
    }
       
    // MovePointer translates pointer according to supplied tuple
    public void MovePointer((float, float) t1)
    {
        Vector3 currPosition = Heart.transform.position;
        Vector3 newPosition = currPosition + new Vector3(t1.Item1 * 0.3f, t1.Item2 * 0.3f, 0);
        if ((newPosition - Background.transform.position).magnitude <= Background.GetComponent<Renderer>().bounds.size.x / 2)
        {
            Heart.transform.position = newPosition;
        } else
        {
            Vector3 correction = (newPosition - Background.transform.position).normalized;
            Heart.transform.position = Background.transform.position + correction * Background.GetComponent<Renderer>().bounds.size.x / 2;

        }
    }
    
    // Dummy spell
    public void SPELL1()
    {
        MovePointer((-2, 1));
    }

    public void SPELL2()
    {
        MovePointer((3, -1));
    }

    void Start()
    {
        ResetHeart();
    }


    void Update()
    {
        //for testing
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SPELL1();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SPELL2();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ResetHeart();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            IncreaseStability();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            DecreaseStability();
        }
        PointerUpdate();
        Debug.Log("Quadrant: " + CurrentQuadrant + ", Stability: " + IsStable + ", Within: " + WithinWheel);
        
    }


}
