﻿using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 4000f;
    public float SidwardForce = 100f;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void FixedUpdate() //Add the word  'FIXED' when using physics
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidwardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(SidwardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 0f )
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
 