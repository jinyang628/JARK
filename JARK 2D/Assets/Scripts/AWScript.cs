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
    
    // Resets heart to centre of wheel
    public void Reset_Heart()
    {
        BGPosition = new Vector2(Background.transform.position.x, Background.transform.position.y);
        Heart.transform.position = BGPosition;
    }

    // Stability changes are currently hard-coded...
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
    // Check if heart is in stability zone
    public bool IsStable => Heart.GetComponent<Collider2D>().bounds.Intersects(StabilityZone.GetComponent<Collider2D>().bounds);

    void Start()
    {
        Reset_Heart();
    }

    // For test scene, delete later
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontalInput, verticalInput);
        
        Heart.transform.Translate(movement * -6.0f * Time.deltaTime);
        
        if (IsStable)
        {
            Debug.Log("Stable");
        }
    }
    
}
