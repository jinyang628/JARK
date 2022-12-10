using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //
    public Rigidbody player;
    [Header("Gameplay Settings")]
    public float thrustStrength = 10f;

    private float currentFuel;

    // Start is called before the first frame update 
    void Start()
    {
        
    }
    // Update is called once per frame 
    void Update()
    {
        // Check if there is sufficient fuel for one burst of all nozzles 
        if (currentFuel > 3 * nozzleFuelConsumptionRate * Time.deltaTime)
        {
            Thrust();
        }
    }

    void Thrust()
    {
        // Forward and backward velocity 
        if ((Input.GetKey(KeyCode.W)  Input.GetKey(KeyCode.UpArrow)) != (Input.GetKey(KeyCode.S)  Input.GetKey(KeyCode.DownArrow)))  
        {
            bool forward = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
            player.AddForce(thrustStrength * (forward ? transform.forward : -transform.forward));
        }
        // Upwards and downwards velocity 
        if (Input.GetKey(KeyCode.Space) != Input.GetKey(KeyCode.C))
        {
            // todo    
            bool up = Input.GetKey(KeyCode.Space);
            player.AddForce(thrustStrength * (up ? transform.up : -transform.up));
        }
        // Left and right velocity 
        if ((Input.GetKey(KeyCode.A)  Input.GetKey(KeyCode.RightArrow))) 
        {
            // todo 
            bool right = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
            player.AddForce(thrustStrength * (right ? transform.right : -transform.right));
        }
    }
