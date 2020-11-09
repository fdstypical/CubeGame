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
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(h * speed * Time.deltaTime, 0, v * speed * Time.deltaTime);

        transform.Translate(movement);
    }
}
