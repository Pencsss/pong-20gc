using UnityEngine;
using TMPro;
public class GoalLeft : MonoBehaviour
{
    public TextMeshProUGUI rightPlayerScoreText;
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
            Debug.Log("Goal Scored! Point to Right Player");
            other.gameObject.GetComponent<BallMovement>().ResetBall();
            rightPlayerScoreText.text = (int.Parse(rightPlayerScoreText.text) + 1).ToString();
        }
    }
}
