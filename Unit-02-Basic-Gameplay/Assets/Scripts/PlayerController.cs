using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction moveAction;
    private Vector2 moveInput;

    private void Start()
    {
        moveAction.Enable();
    }

    private void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
    }
}
