using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Return_to_Spawn : MonoBehaviour
{
    public GameObject spawnPoint; // Assign this in the Inspector to the desired spawn point
    public GameObject player;    // Assign the player GameObject in the Inspector
    public GameObject plane;     // Assign the plane GameObject in the Inspector

    // Start is called before the first frame update
    void Start()
    {
        if (spawnPoint == null)
        {
            Debug.LogError("Spawn point not set. Please assign a spawn point in the Inspector.");
        }
        if (player == null)
        {
            Debug.LogError("Player object not set. Please assign the player object in the Inspector.");
        }
        if (plane == null)
        {
            Debug.LogError("Plane object not set. Please assign the plane object in the Inspector.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == plane)
        {
            Debug.Log("Player has collided with the plane. Returning to spawn point.");
            
            // Reset the player's position and rotation to the spawn point
            player.transform.position = spawnPoint.transform.position;
            player.transform.rotation = spawnPoint.transform.rotation;
        }
    }
}