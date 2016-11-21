using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    #region Fields
    public GameObject player;
    private Vector3 offset;
    #endregion

    void Start()
    {
        //Get the delta of the starting point between the player and camera
        offset = transform.position - player.transform.position;
    }

    /// <summary>
    /// Happens every frame after 
    /// </summary>
    void LateUpdate()
    {
        //Adjust the camera position to follow the player
        transform.position = player.transform.position + offset;
    }
}
