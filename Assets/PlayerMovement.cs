using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    void FixedUpdate()
    {
        Vector3 move = (transform.right * moveInput.x + transform.forward * moveInput.y) * moveSpeed;
        rb.MovePosition(rb.position + move * Time.fixedDeltaTime);
    }

}
