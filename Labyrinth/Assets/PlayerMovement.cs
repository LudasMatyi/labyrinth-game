using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 500f;

    public Vector3 forward;
    public Vector3 backward;
    public Vector3 left;
    public Vector3 right;
    public Vector3 none;

    private void Start()
    {
        forward = new Vector3(0, 0, speed * Time.deltaTime);
        backward = new Vector3(0, 0, -speed * Time.deltaTime);
        left = new Vector3(-speed * Time.deltaTime, 0, 0);
        right = new Vector3(speed * Time.deltaTime, 0, 0);
    }

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.velocity = forward;
        }
        else if (Input.GetKey("s"))
        {
            rb.velocity = backward;
        }
        else if (Input.GetKey("a"))
        {
            rb.velocity = left;
        }
        else if (Input.GetKey("d"))
        {
            rb.velocity = right;
        }
    }
}
