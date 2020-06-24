using UnityEngine;
using UnityEngine.UI;

public class coinCollider : MonoBehaviour
{
    private static int coinCount = 0;
    private static int totalCoin;
    public Text coinCountText;
    public void OnTriggerEnter2D(Collider2D other)
    {
        coinCount = PlayerPrefs.GetInt("Coin");
        coinCount = coinCount + 1;
        PlayerPrefs.SetInt("Coin",coinCount);
        coinCountText = GameObject.FindGameObjectWithTag("coinScore").GetComponent<Text>();
        coinCountText.text = "x" + PlayerPrefs.GetInt("Coin");
        Destroy(gameObject);
        totalCoin = PlayerPrefs.GetInt("totalCoin");
        totalCoin = totalCoin + 1;
        PlayerPrefs.SetInt("totalCoin",totalCoin);
    }
    
}
