using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
   {
     public Joystick joystick;
     private Animation anim;

     public float speed;
     public float rotationSpeed;

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        anim = GetComponent<Animation>();
    }
    

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;


          if (horizontal != 0 && vertical != 0)
          {
           anim.Play("Walking");
          }
          else
          {
           anim.Stop("Walking");
          }

          
        Vector3 movementDirection = new Vector3(horizontal, 0, vertical);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
        
        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);            
        }
    }
}
