using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject Player;//In the unity UI - drag the player game object into the "Player" variable inside the camera's script component
    private Vector3 offset;
    
	// Use this for initialization
	void Start ()
    {
        //Get the difference between the camera's position and the player position
        offset = transform.position - Player.transform.position;
	}
	
    /// <summary>
    /// Runs once every frame after all items have been processed in update
    /// </summary>
	void LateUpdate ()
    {
        //Adjusts the position of the camera to follow the player movements
        transform.position = Player.transform.position + offset;
	}
}
