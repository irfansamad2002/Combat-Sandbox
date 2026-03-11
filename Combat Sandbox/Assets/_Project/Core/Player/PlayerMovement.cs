using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 6f;

    private CharacterController controller;
    private Vector3 moveDirection;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveInput = transform.right * x + transform.forward * z;
        moveInput.Set(moveInput.x, 0f, moveInput.z);   
        controller.Move(moveInput * moveSpeed * Time.deltaTime);
    }
}

