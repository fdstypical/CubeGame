using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // float h = Input.GetAxis("Horizontal");
        // float v = Input.GetAxis("Vertical");
        // Vector3 movement = new Vector3(h * speed, rb.velocity.y, v * speed);

        // rb.AddForce(movement);

        transform.Translate(new Vector3(-0.01f, 0,0));
    }
}
