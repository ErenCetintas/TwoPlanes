using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSquare : MonoBehaviour
{
    int speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed=10;
        rb=GetComponent<Rigidbody2D>();
        rb.velocity=new Vector2(0,-speed);
    }
}
