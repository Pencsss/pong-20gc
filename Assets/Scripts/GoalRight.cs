using UnityEngine;
using TMPro;
public class GoalRight : MonoBehaviour
{
    public TextMeshProUGUI leftPlayerScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("Goal Scored! Point to Left Player");
            other.gameObject.GetComponent<BallMovement>().ResetBall();
            leftPlayerScoreText.text = (int.Parse(leftPlayerScoreText.text) + 1).ToString();
        }
    }
}
