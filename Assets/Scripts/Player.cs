using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float mouseSens = 5;
    public float speed;
    float mouseX;


    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSens;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Quaternion rotationY =Quaternion.AngleAxis(mouseX, Vector3.up); 
        Vector3 movement = new Vector3(h * speed * Time.deltaTime, 0, v * speed * Time.deltaTime);

        transform.Translate(movement);
        transform.rotation *= rotationY;
    }
}
