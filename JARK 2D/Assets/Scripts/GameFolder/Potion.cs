using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    public GameObject potionObj;
    private float floatingSpeed = 1.0f;
    private float amplitude = 0.1f;
    private float y_init;

    // Start is called before the first frame update
    void Start()
    {
        y_init = potionObj.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float delta = amplitude * Mathf.Sin(floatingSpeed * Time.time);
        potionObj.transform.position = new Vector3(potionObj.transform.position.x, y_init + delta, 0f);
    }
}
