using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCircleSquare : MonoBehaviour
{
    public GameObject RedCrashDestroyEffect;
    public GameObject BlueCrashDestroyEffect;

    public GameObject RedCrashEffect;
    public GameObject BlueCrashEffect;

    public static bool endGame;

    void Start(){
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        //destroy gameobject---------
        if(other.gameObject.tag == "Destroyer"){
            //square destroyer
            if(this.gameObject.tag == "RedSquare"){
                Destroy(this.gameObject);
                //effect
                GameObject objectToDestroy = Instantiate(RedCrashDestroyEffect, transform.position, transform.rotation);
                Destroy(objectToDestroy,1);
            }
            if(this.gameObject.tag == "BlueSquare"){
                Destroy(this.gameObject);
                //effect
                GameObject objectToDestroy = Instantiate(BlueCrashDestroyEffect, transform.position, transform.rotation);
                Destroy(objectToDestroy,1);
            }
            //endGame control
            if(this.gameObject.tag == "CircleRed" || this.gameObject.tag == "CircleBlue"){
                endGame=true;
                Time.timeScale=0;
            }

        }
        //endGame control
        if(other.gameObject.tag == "Plane"){
            //endGame control----------
            if(this.gameObject.tag == "RedSquare"){
                Destroy(this.gameObject);
                GameObject objectToDestroy = Instantiate(RedCrashEffect, transform.position, transform.rotation);
                Destroy(objectToDestroy,1);
                //time control----
                //Time.timeScale=0;
            }
            if(this.gameObject.tag == "BlueSquare"){
                Destroy(this.gameObject);
                GameObject objectToDestroy = Instantiate(BlueCrashEffect, transform.position, transform.rotation);
                Destroy(objectToDestroy,1);
                //time control----
                //Time.timeScale=0;
            }
            //get points counter---------
            if(this.gameObject.tag == "CircleRed"){
                Destroy(this.gameObject);
                GameObject objectToDestroy = Instantiate(RedCrashEffect, transform.position, transform.rotation);
                Destroy(objectToDestroy,1);
                //get points----
                ScoreManager.score = ScoreManager.score + 20;
            }
            if(this.gameObject.tag == "CircleBlue"){
                Destroy(this.gameObject);
                GameObject objectToDestroy = Instantiate(BlueCrashEffect, transform.position, transform.rotation);
                Destroy(objectToDestroy,1);
                //get points----
                ScoreManager.score = ScoreManager.score + 20;
            }
        }


    }
}
