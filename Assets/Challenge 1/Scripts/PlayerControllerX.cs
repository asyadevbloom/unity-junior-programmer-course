using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    public InputAction moveAction;
    private Vector2 moveInput;

    void Start()
    {
        moveAction.Enable();
    }

    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
      
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime * moveInput.y * (-1));  
    }
}
