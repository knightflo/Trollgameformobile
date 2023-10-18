using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Camerateleport : MonoBehaviour
{
    public GameObject block;
    public Camera Camera;
    public BoxCollider2D box;
    public Boolean incollider = false;
    public string scene;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (scene == "firstscene")
            {
                
                incollider = true;
                Camera.transform.position = new Vector3(17.78f, 0, -10f);
                
            }
            if (scene == "secondscene")
            {
                //SceneManager.LoadScene("secondscene", LoadSceneMode.Single);
                
                
                incollider = true;
                Camera.transform.position = new Vector3(17.78f, -6.01f, -10f);
                
            }
            if (scene == "thirdscene")
            {
                incollider = true;
                Camera.transform.position = new Vector3(32.70f, -6.01f, -10f);
            }
            if (scene == "fourthscene")
            {
                incollider = true;
                Camera.transform.position = new Vector3(48.47f, -6.01f, -10f);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            box.isTrigger = false;
            incollider=false;
        }
    }
}
