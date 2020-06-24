using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
  private static int score = 0;
  public Text countText;
  public void OnTriggerEnter2D(Collider2D other)
  {
    score = PlayerPrefs.GetInt("PlayerScore", score);
    score++;
    Debug.Log(score);
    countText = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
    PlayerPrefs.SetInt("PlayerScore",score);
    countText.text = "Score : " + PlayerPrefs.GetInt("PlayerScore");

  }
}
