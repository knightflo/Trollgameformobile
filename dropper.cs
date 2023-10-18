using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    public GameObject platform;
    public GameObject player;
    private Boolean launch = false;
    private float yPosition = -8.6027f;
    private float xPosition = 32.1867f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            launch = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (launch)
        {
            yPosition -= 0.5f;
            platform.transform.position = new Vector3(xPosition, yPosition, 0);
            player.transform.position = new Vector3(player.transform.position.x, yPosition+2f, 0);
        }
    }
}
