using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public enum Score
    {
        EnemyScore, PlayerScore
    }

    public Text EnemyScoreText, PlayerScoreText;
    private int EnemyScore, playerScore;

    public void Increment(Score whichScore)
    {
        if (whichScore == Score.EnemyScore)
            EnemyScoreText.text = (++EnemyScore).ToString();
        else
            PlayerScoreText.text = (++playerScore).ToString();
    }


}
