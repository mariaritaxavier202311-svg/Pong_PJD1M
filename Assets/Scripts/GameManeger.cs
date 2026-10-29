using UnityEditor.Build.Reporting;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManeger : MonoBehaviour
{
    [SerializeField] private int playerScore;
    [SerializeField] private int aiScore;
    [SerializeField] private TextMeshProUGUI playerScoreText;
    [SerializeField] private TextMeshProUGUI aiScoreText;
   
    public void PlayerAddPoint()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();

    }
}
