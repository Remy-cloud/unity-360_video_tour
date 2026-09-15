using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 3f;

    private float rotationX = 0f;
    private float rotationY = 0f;

    private void Update()
    {
        if (Mouse.current.rightButton.isPressed)
        {
            Vector2 delta = Mouse.current.delta.ReadValue();

            rotationX += delta.x * sensitivity * 0.1f;
            rotationY -= delta.y * sensitivity * 0.1f;
            rotationY = Mathf.Clamp(rotationY, -90f, 90f);

            transform.localRotation = Quaternion.Euler(rotationY, rotationX, 0f);
        }
    }
}
