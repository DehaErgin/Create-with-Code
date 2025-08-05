using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input 
        verticalInput = Input.GetAxisRaw("Vertical");
        horizontalInput = Input.GetAxisRaw("Horizontal");

        //Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //Rotates the car based on horizontal input 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
    
    
}
