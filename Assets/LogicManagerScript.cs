using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void addScore(int value)
    {
        playerScore += value;
        scoreText.text = playerScore.ToString();
    }
}
