using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour
{
    
    public CharacterController2D controller;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    void update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.deltaTime, false, false);
    }
}
    

