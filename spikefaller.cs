using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class spikefaller : MonoBehaviour
{
    public GameObject spike;
    private Boolean launch = false;
    private float yPosition = -3.6954f;
    private float xPosition = 21.28f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (launch)
        {
            yPosition -= 0.5f;
            spike.transform.position = new Vector3(xPosition, yPosition, 0);
        }
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            launch = true;
        }
    }
}
