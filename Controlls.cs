using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

using UnityEngine;
using UnityEngine.EventSystems;


public class Controlls : MonoBehaviour
{
    Boolean hold = false;
    Boolean holdfard = false;
    public float gravity = -0f;
    //how fast you jump
    public float jumpspeed = 10;
    //baseline for gravity
    private float mingravity;
    public float move;
    public GameObject box;
    public Rigidbody2D m_rigidbody;
    Vector2 m_NewForce;
    public CharacterController CharacterController;
    private Boolean isGrounded = false;
    void Start()
    {
        //Set minGravity (baseline for gravity) to the starting value of gravity
        mingravity = gravity;
    }

    public void holdup()
    {
        holdfard = true;
    }
    public void holddown()
    {
        holdfard = false;
    }
    public void holdture()
    {
        hold = true;
    }
    public void holdfuncs()
    {
        hold = false;
    }
    public void jump()
    {
        if (isGrounded){
            isGrounded = false;
            m_NewForce = new Vector2(0, 30);
            m_rigidbody.AddForce(m_NewForce, ForceMode2D.Impulse);
            /* //first set gravity to baseline gravity
             gravity = mingravity;
             //reverse gravity to upwards with the speed of jumpspeed
             gravity *= -jumpspeed;*/
        }

    }

    void FixedUpdate()
    {
        //transform.position = new Vector3(move, gravity, 0);
        transform.Translate(new Vector3(move, 0, 0));
        if (hold||Input.GetKey(KeyCode.D))
        {
            
            move = 10 * Time.deltaTime;

        }
        
        else if (holdfard|| Input.GetKey(KeyCode.A))
        {
            move = -10 * Time.deltaTime;
        }
        else
        {
            move = 0 * Time.deltaTime;
        }
       /* if (gravity > mingravity)
        {
            gravity -= 5 * Time.deltaTime;
        }*/
        if (Input.GetKeyDown(KeyCode.W))
        {
            jump();
        }
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player has collided with the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}