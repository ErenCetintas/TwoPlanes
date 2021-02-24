using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementScript : MonoBehaviour
{
    public Vector2 Xpos;
    
    public bool FirstLaneRightPlane, FirstLaneLeftPlane;
    public bool LeftPlaneControl;

    public GameObject touchPlaneEffect;
    
    float rotZ=15;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
         if(LeftPlaneControl){
             if(FirstLaneLeftPlane){
                transform.position = Vector3.Lerp(transform.position,new Vector3(-Xpos.y,transform.position.y,0),.1f);
                if(transform.position.x>= -1.3f){
                transform.rotation = Quaternion.Euler(0,0,0);
                }else{
                transform.rotation = Quaternion.Euler(0,0,-rotZ);
                }
             }
             else{
                transform.position = Vector3.Lerp(transform.position,new Vector3(-Xpos.x,transform.position.y,0),.1f); 
                if(transform.position.x<= -2.7f){
                transform.rotation = Quaternion.Euler(0,0,0);
                }else{
                transform.rotation = Quaternion.Euler(0,0,rotZ);
                }
             }

         }else{
             if(FirstLaneRightPlane){
                transform.position = Vector3.Lerp(transform.position,new Vector3(Xpos.y,transform.position.y,0),.1f);
                if(transform.position.x<=1.3f){
                transform.rotation = Quaternion.Euler(0,0,0);
                }else{
                transform.rotation = Quaternion.Euler(0,0,rotZ);
                }
             }
             else{
                transform.position = Vector3.Lerp(transform.position,new Vector3(Xpos.x,transform.position.y,0f),.1f); 
                if(transform.position.x>=2.7f){
                transform.rotation = Quaternion.Euler(0,0,0);
                }else{
                transform.rotation = Quaternion.Euler(0,0,-rotZ);
                }
             }
         } 
             
    }

    public void LeftButton(){
        if(FirstLaneLeftPlane){
            FirstLaneLeftPlane=false;
        }else{
            FirstLaneLeftPlane=true;
        }
        Instantiate(touchPlaneEffect, new Vector3(transform.position.x,transform.position.y-1,transform.position.z), transform.rotation);
    }

    public void RightButton(){
        if(FirstLaneRightPlane){
            FirstLaneRightPlane=false;
        }else{
            FirstLaneRightPlane=true;
        }
        Instantiate(touchPlaneEffect, new Vector3(transform.position.x,transform.position.y-1,transform.position.z), transform.rotation);
    }
}

