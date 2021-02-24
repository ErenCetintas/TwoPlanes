using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCircleSquare : MonoBehaviour
{
    public GameObject RedCrashDestroyEffect;
    public GameObject BlueCrashDestroyEffect;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Destroyer"){
            Destroy(this.gameObject);
            if(this.gameObject.tag == "RedSquare"){
                GameObject objectToDestroy = Instantiate(RedCrashDestroyEffect, transform.position, transform.rotation);
                Destroy(objectToDestroy,1);
            }
            if(this.gameObject.tag == "BlueSquare"){
                GameObject objectToDestroy = Instantiate(BlueCrashDestroyEffect, transform.position, transform.rotation);
                Destroy(objectToDestroy,1);
            }
        }

    }
}
