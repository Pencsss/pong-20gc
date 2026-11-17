using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float forceAmount = 10f;
    private Rigidbody2D rb2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>().linearDamping = 0;
        rb2D = GetComponent<Rigidbody2D>();
        ApplyRandomForce2D();
    }

    void ApplyRandomForce2D()
    {
        Vector2 randomDirection = Random.insideUnitCircle.normalized;

        if (randomDirection == Vector2.zero)
        {
            randomDirection = Vector2.right;
        }

        Vector2 finalforce = randomDirection * forceAmount;
        rb2D.AddForce(finalforce, ForceMode2D.Impulse);
    }

    public void ResetBall()
    {
        rb2D.linearVelocity = Vector2.zero;
        transform.position = Vector2.zero;
        ApplyRandomForce2D();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
