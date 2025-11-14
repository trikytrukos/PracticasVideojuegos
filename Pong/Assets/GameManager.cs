using UnityEngine;
using TMPro;





public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text Paddle1ScoreText;
    [SerializeField] private TMP_Text Paddle2ScoreText;

    [SerializeField] private Transform Paddle1ScoreTransform;
    [SerializeField] private Transform Paddle2ScoreTransform;
    [SerializeField] private Transform BallTransform;

    private int paddle1Score;
    private int paddle2Score;

    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    public void Paddle1Scored () {
        paddle1Score++;
        Paddle1ScoreText.text = paddle1Score.ToString();
    }

    public void Paddle2Scored()
    {
        paddle2Score++;
        Paddle2ScoreText.text = paddle2Score.ToString();
    }

    public void Restart()
    {
        Paddle1ScoreTransform.position = new Vector2(Paddle1ScoreTransform.position.x, 0);
        Paddle2ScoreTransform.position = new Vector2(Paddle2ScoreTransform.position.x, 0);
        BallTransform.position = new Vector2(0, 0);
    }

}