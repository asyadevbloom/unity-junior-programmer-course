using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // movement tuning
    public float speed = 5.0f;
    public float turnSpeed;

    // input system action exposed in Inspector for binding
    public InputAction moveAction;
    // current input value (x = left/right, y = forward/back)
    private Vector2 moveInput;

    void Start()
    {
        //it starts reading input
        moveAction.Enable();
    }

    void Update()
    {
        // read the 2D vector from the moveAction (x: horizontal, y: vertical);
        moveInput = moveAction.ReadValue<Vector2>();
        
        // move vehicle forward/backward along local Z using the y component
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        
        // rotate around local Y using the x component
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
}
