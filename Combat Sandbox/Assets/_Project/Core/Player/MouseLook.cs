using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    private float yRotation = 0f;
    private float xRotation = 0f;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float leftRightDelta = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float upDownDelta = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation += leftRightDelta;
        yRotation -= upDownDelta;
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        Vector3 inputRotationVec3 = new Vector3(upDownDelta, leftRightDelta, 0f);

        transform.localRotation = Quaternion.Euler(yRotation,xRotation,0);
    }
}
