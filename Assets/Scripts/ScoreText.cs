using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Text currentScore;
    private Text highScore;
    private Text currentCoin;
    private Text TotalCoin;    

    private void Start()
    {
        currentScore = GameObject.FindGameObjectWithTag("currentScore").GetComponent<Text>();
        highScore = GameObject.FindGameObjectWithTag("highScore").GetComponent<Text>();
        currentCoin = GameObject.FindGameObjectWithTag("coinScoreGameOverScene").GetComponent<Text>();
        TotalCoin = GameObject.FindGameObjectWithTag("totalCoin").GetComponent<Text>();
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("PlayerScore") > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore",PlayerPrefs.GetInt("PlayerScore"));
            
        }
        currentScore.text = "Current Score : " + PlayerPrefs.GetInt("PlayerScore");
        highScore.text = "High Score : " + PlayerPrefs.GetInt("HighScore");
        currentCoin.text = "x" + PlayerPrefs.GetInt("Coin");
        TotalCoin.text = "x" + PlayerPrefs.GetInt("totalCoin");

    }
}
