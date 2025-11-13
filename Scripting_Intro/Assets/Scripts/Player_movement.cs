using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public float speed = 1.5f;
    public float rotationSpeed = 100.0f;
    private Rigidbody Physics;
    public float jumpForce = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        Physics = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");// -1 si el usuario presiona izquierda, 1 si presiona derecha
        float vertical = Input.GetAxis("Vertical");// -1 si el usuario presiona abajo, 1 si presiona arriba
        transform.Translate(new Vector3(horizontal, 0, vertical) * Time.deltaTime * speed);
        float rotacionY = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, rotacionY, 0) * Time.deltaTime * rotationSpeed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.AddForce(new Vector3(0,jumpForce,0));
        }
    }
}
