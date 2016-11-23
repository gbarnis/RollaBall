using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float Speed;//Public global variable - allows modification from the Unity editor 
    public Text countText;
    public Text WinText;

    private Rigidbody rb;
    private int count;

    /// <summary>
    /// Called on the first frame where the script is active
    /// </summary>
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        WinText.text = "";
        setCountText();
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

    /// <summary>
    /// Pick up objects
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        //The pick up objects are defined with rigid body and kinematics
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
    }

    void setCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
            WinText.text = "You Win!";
    }

}