using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovementRight : MonoBehaviour
{
    public int moveSpeed = 5;
    private Rigidbody2D rb2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.upArrowKey.isPressed)
        {
            rb2D.linearVelocity = new Vector2(0, moveSpeed);
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            rb2D.linearVelocity = new Vector2(0, -moveSpeed);
        }
        else
        {
            rb2D.linearVelocity = Vector2.zero;
        }
    }
}
