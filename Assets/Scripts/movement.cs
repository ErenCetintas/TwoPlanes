using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Gameobject LeftPlane;
    public Gameobject RightPlane;
    
    void Start(){
        
    }

    void Update(){
        
    }

    public void LeftButton(){

        if(LeftPlane.transform.position.x == -3f;){
            LeftPlane.transform.position.x = 3f;
        }
        else if (LeftPlane.transform.position.x == 3f;){
            LeftPlane.transform.position.x = -3f;
        }

    }

    public void RightButton(){
        
    }
}
