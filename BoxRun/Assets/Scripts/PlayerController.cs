using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
