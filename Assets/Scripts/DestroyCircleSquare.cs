using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCircleSquare : MonoBehaviour
{
    public GameObject RedCrashDestroyEffect;
    public GameObject BlueCrashDestroyEffect;

    public GameObject RedCrashEffect;
    public GameObject BlueCrashEffect;

    public GameObject endGameEffect;

    public static bool endGame;

    void Start(){
        endGame=false;
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        
        //destroy gameobject---------
        if(other.gameObject.tag == "Destroyer"){
            DestroyEnemy(other);
        }
        //endGame control----------
        if(other.gameObject.tag == "Plane"){
            GetPoints(other);
        }
        
        
    }
    void DestroyEnemy (Collider2D other){
        
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
                Instantiate(endGameEffect, new Vector3(transform.position.x,transform.position.y,transform.position.z), transform.rotation);
                endGame=true;
                Time.timeScale=0;
                FindObjectOfType<soundManager>().Play("Destroy");
            }
        
    }
    void GetPoints (Collider2D other){
            //endGame control----------
            if(this.gameObject.tag == "RedSquare"){
                Destroy(this.gameObject);
                GameObject objectToDestroy = Instantiate(RedCrashEffect, transform.position, transform.rotation);
                Destroy(objectToDestroy,1);
                endGame=true;
                Time.timeScale=0;
                FindObjectOfType<soundManager>().Play("Destroy");
            }
            if(this.gameObject.tag == "BlueSquare"){
                Destroy(this.gameObject);
                GameObject objectToDestroy = Instantiate(BlueCrashEffect, transform.position, transform.rotation);
                Destroy(objectToDestroy,1);
                endGame=true;
                Time.timeScale=0;
                FindObjectOfType<soundManager>().Play("Destroy");
            }
            //get points counter---------
            if(this.gameObject.tag == "CircleRed"){
                Destroy(this.gameObject);
                GameObject objectToDestroy = Instantiate(RedCrashEffect, transform.position, transform.rotation);
                Destroy(objectToDestroy,1);
                //get points----
                ScoreManager.score = ScoreManager.score + 1;
                FindObjectOfType<soundManager>().Play("Circle");
            }
            if(this.gameObject.tag == "CircleBlue"){
                Destroy(this.gameObject);
                GameObject objectToDestroy = Instantiate(BlueCrashEffect, transform.position, transform.rotation);
                Destroy(objectToDestroy,1);
                //get points----
                ScoreManager.score = ScoreManager.score + 1;
                FindObjectOfType<soundManager>().Play("Circle");
            }
        
    }
}
