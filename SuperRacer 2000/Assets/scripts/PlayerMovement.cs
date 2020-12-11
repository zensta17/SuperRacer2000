using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 100f;
    public float sidewaysForce = 500f;
    public float jumpForce = 1000f;
    public bool left;
    public bool right;
    public bool up;

 
    void FixedUpdate()
    {


        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce, ForceMode.Acceleration);
        }
        Debug.Log(rb.velocity);

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
