using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementScript : MonoBehaviour
{
    /*public GameObject LeftPlane;
    public GameObject RightPlane;*/

    public Vector2 Xpos;
    
    public bool FirstLaneRightPlane, FirstLaneLeftPlane;
    public bool LeftPlaneControl;
    
    void Start()
    {
        
    }

   
    void FixedUpdate()
    {
         if(LeftPlaneControl){
             if(FirstLaneLeftPlane){
                transform.position = Vector3.Lerp(transform.position,new Vector3(-Xpos.y,transform.position.y,0),.1f);
             }
             else{
                transform.position = Vector3.Lerp(transform.position,new Vector3(-Xpos.x,transform.position.y,0),.1f); 
             }

         }else{
             if(FirstLaneRightPlane){
                transform.position = Vector3.Lerp(transform.position,new Vector3(Xpos.y,transform.position.y,0),.1f);
             }
             else{
                transform.position = Vector3.Lerp(transform.position,new Vector3(Xpos.x,transform.position.y,0),.1f); 
             }
         }      
    }

    public void LeftButton(){
        if(FirstLaneLeftPlane){
            FirstLaneLeftPlane=false;
        }else{
            FirstLaneLeftPlane=true;
        }
    }

    public void RightButton(){
        if(FirstLaneRightPlane){
            FirstLaneRightPlane=false;
        }else{
            FirstLaneRightPlane=true;
        }
    }
}

