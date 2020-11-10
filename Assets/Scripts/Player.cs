using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float mouseSens = 5;
    public float speed;
    float mouseX;
    bool mouseDown = false;


    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown() {
        mouseDown = true;
    }

    void OnMouseUp() {
        mouseDown = false;
    }

    void Update()
    {
        int isMouseDownInt = mouseDown ? 1 : 0;
        mouseX = Input.GetAxis("Mouse X") * mouseSens * isMouseDownInt;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Quaternion rotationY =Quaternion.AngleAxis(mouseX, Vector3.up); 
        Vector3 movement = new Vector3(h * speed * Time.deltaTime, 0, v * speed * Time.deltaTime);

        transform.Translate(movement);
        transform.rotation *= rotationY;
    }
}
