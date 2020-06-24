using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class ButtonHandler : MonoBehaviour
{
    
    private Text YetersizBakiye;
    private static int buy1 = 10000;
    private static int buy2 = 15000;
    private static int buy3 = 20000;
    private static int newCoin;

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
        PlayerPrefs.SetInt("PlayerScore",0);
        PlayerPrefs.SetInt("Coin",0);
    }

    public void startGame()
    {
        SceneManager.LoadScene("GameScene");
        PlayerPrefs.SetInt("PlayerScore",0);
        PlayerPrefs.SetInt("Coin",0);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("WelcomeScene");
    }

    public void shopScene()
    {
        SceneManager.LoadScene("ShopScene");
    }

    public void buttonClickzero()
    {
        PlayerPrefs.SetInt("setCharacter",0);
    }
    public void buttonClickone()
    {
        YetersizBakiye = GameObject.FindGameObjectWithTag("yetersizBakiye").GetComponent<Text>();
        if (PlayerPrefs.GetInt("isBought") != 1)
        {
            if (PlayerPrefs.GetInt("totalCoin") >= buy1)
            {
                newCoin = PlayerPrefs.GetInt("totalCoin") - buy1;
                PlayerPrefs.SetInt("totalCoin",newCoin);
                PlayerPrefs.SetInt("character1",1);
                GameObject.Find("buttonName").GetComponentInChildren<Text>().text = "Owned";
                PlayerPrefs.SetInt("isBought",1);
                
            }    
            else if(PlayerPrefs.GetInt("totalCoin")<buy1)
            {
              Debug.Log("Yetersiz Bakiye");
              YetersizBakiye.enabled = true;
              StartCoroutine(waitForSeconds());
            }
        }
        Debug.Log(PlayerPrefs.GetInt("setCharacter"));
        if (PlayerPrefs.GetInt("isBought") == 1)
        {
            PlayerPrefs.SetInt("setCharacter",1);
        }
        
    }
    public void buttonClicktwo()
    {
        YetersizBakiye = GameObject.FindGameObjectWithTag("yetersizBakiye").GetComponent<Text>();
        if (PlayerPrefs.GetInt("isBought1") != 1 )
        {
            if (PlayerPrefs.GetInt("totalCoin") >= buy2)
            {
                newCoin = PlayerPrefs.GetInt("totalCoin") - buy2;
                Debug.Log(newCoin);
                PlayerPrefs.SetInt("totalCoin",newCoin);
                PlayerPrefs.SetInt("character2",1);
                PlayerPrefs.SetInt("isBought1",1);
                
            }    
            else if(PlayerPrefs.GetInt("totalCoin")<buy2)
            {
                Debug.Log("Yetersiz Bakiye");
                YetersizBakiye.enabled = true;
                StartCoroutine(waitForSeconds());
            }
        }
        Debug.Log(PlayerPrefs.GetInt("setCharacter"));
        if (PlayerPrefs.GetInt("isBought1") == 1)
        {
            PlayerPrefs.SetInt("setCharacter",2);
        }
    }
    public void buttonClickthree()
    {
        YetersizBakiye = GameObject.FindGameObjectWithTag("yetersizBakiye").GetComponent<Text>();
        
        if (PlayerPrefs.GetInt("isBought2") != 1)
        {
            if (PlayerPrefs.GetInt("totalCoin") >= buy3)
            {
                newCoin = PlayerPrefs.GetInt("totalCoin") - buy3;
                PlayerPrefs.SetInt("totalCoin",newCoin);
                PlayerPrefs.SetInt("character3",1);
                GameObject.Find("buttonName2").GetComponentInChildren<Text>().text = "Owned";
                PlayerPrefs.SetInt("isBought2",1);
                
            }    
            else if(PlayerPrefs.GetInt("totalCoin")<buy3)
            {
                Debug.Log("Yetersiz Bakiye");
                YetersizBakiye.enabled = true;
                StartCoroutine(waitForSeconds());
            }
        }
        Debug.Log(PlayerPrefs.GetInt("setCharacter"));
        if (PlayerPrefs.GetInt("isBought2") == 1)
        {
            PlayerPrefs.SetInt("setCharacter",3);
        }
    }

     IEnumerator waitForSeconds()
    {
        yield return new WaitForSecondsRealtime(2);
        YetersizBakiye.enabled = false;
    }
    
}
