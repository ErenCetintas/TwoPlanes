using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSquare : MonoBehaviour
{
    public static float speed = 6;
    Rigidbody2D rb;

    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rb=GetComponent<Rigidbody2D>();
        rb.velocity = -transform.up * speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        Debug.Log(speed);
    }
}
