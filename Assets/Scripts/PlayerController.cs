using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float Speed;//Public global variable - allows modification from the Unity editor 
    private Rigidbody rb;

    /// <summary>
    /// Called on the first frame where the script is active
    /// </summary>
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// FixedUpdate should be used instead of Update when dealing with Rigidbody
    /// </summary>
    void FixedUpdate()
    {
        float moveHorizontaly = Input.GetAxis("Horizontal");
        float moveVerticaly = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontaly, 0.0f, moveVerticaly);
        rb.AddForce(movement * Speed);
    }

}
