using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    // the player is set via dragging into the Player Follow script in the inspector
    // (when the Main Camera is selected)
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // moving the camera to follow the player's position (at a distance)
        transform.position = player.transform.position + new Vector3(0, 3, -10);
    }
}
