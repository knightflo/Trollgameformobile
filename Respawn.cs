using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public GameObject player;
    public Camera mainCamera;
    public Camerateleport camerateleport;
    public GameObject spike;

    // Update is called once per frame
    void Update()
    {



        // Get the bounds of the player's collider
        Bounds playerBounds = player.GetComponent<Collider2D>().bounds;

        if (!camerateleport.incollider)
        {
            // Check if the player is visible from the camera
            if (!GeometryUtility.TestPlanesAABB(GeometryUtility.CalculateFrustumPlanes(mainCamera), playerBounds))
            {

                // Player is out of camera view, reload the scene
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    
}
