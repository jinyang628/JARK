using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AWScript : MonoBehaviour
{
    public GameObject Heart;
    public GameObject Background;
    public GameObject StabilityZone;
    [SerializeField]
    private Vector2 BGPosition;
    
    public void Reset_Heart()
    {
        BGPosition = new Vector2(Background.transform.position.x, Background.transform.position.y);
        Heart.transform.position = BGPosition;
    }

    public void Increase_Stability()
    {
        StabilityZone.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void Decrease_Stability()
    {
        if (StabilityZone.transform.localScale.x > 0.6)
        {
            StabilityZone.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }
            
    }

    void Start()
    {
        Reset_Heart();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontalInput, verticalInput);
        
        Heart.transform.Translate(movement * -6.0f * Time.deltaTime);
    }
    
}
