using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardForce = 1000f;
    public float sidewayForce = 500f;
    public Rigidbody rb;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            MoveRight();
        }
        if (Input.GetKey("a"))
        {
            MoveLeft();
        }
    }

    private void MoveLeft()
    {
        rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
    }

    private void MoveRight()
    {
        rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
    }
}
