
using UnityEngine;
using UnityEngine.InputSystem;

public class Lander : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float thrustPower = 20f;

    [SerializeField]
    private float rotationSpeed = 2f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            rb.AddForce(transform.up * thrustPower);
        }

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            rb.AddTorque(rotationSpeed);
        }
        else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            rb.AddTorque(-rotationSpeed);
        }

    }
}
