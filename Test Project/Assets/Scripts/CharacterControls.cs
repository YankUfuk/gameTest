using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour
{
    
     public float jumpForce = 10f;
     public float gravity = -9.81f;
     float velocity;
     [SerializeField] float moveRight = 0.01f;
     [SerializeField] float moveLeft = -0.01f;
     
     
    void Update()
    {
        velocity += gravity * Time.deltaTime;
        if((Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.RightArrow)) || Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.RightArrow))
        {
            //i can use for loop to make double jump mechanic in the future.
            //int count = 3;
            //for(int i = 0; i <= count; i++){
            // }
            
            
            
           velocity = jumpForce;
           transform.Translate(new Vector3(0,velocity,0)*Time.deltaTime);
        }
            

        else if(Input.GetKey(KeyCode.LeftArrow)){
            float moveSpeedL = (Input.GetAxis("Vertical") * moveLeft)*Time.deltaTime;
            transform.Translate(moveLeft,0,0);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
             float moveSpeedR = (Input.GetAxis("Vertical") * moveRight)*Time.deltaTime;
             transform.Translate(moveRight,0,0);
        }
       
    }

    
}
