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
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        rb=GetComponent<Rigidbody2D>();
        rb.velocity=new Vector2(0,-speed);
        Debug.Log(speed);
    }
}
