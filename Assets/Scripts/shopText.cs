using UnityEngine;
using UnityEngine.UI;

public class shopText : MonoBehaviour
{
    private Text _text;
    private Text _text1;
    private Text _text2;
    private Text _text3;
    private Text _text4;
    private Text YetersizBakiye;
    private void Start()
    {
        _text4 = GameObject.Find("Text (3)").GetComponent<Text>();
        _text3 = GameObject.Find("buttonName2").GetComponentInChildren<Text>();
        _text2 = GameObject.Find("buttonName1").GetComponentInChildren<Text>();
        _text1 = GameObject.Find("buttonName").GetComponentInChildren<Text>();
        _text = GameObject.Find("buttonName (1)").GetComponentInChildren<Text>();
        YetersizBakiye = GameObject.FindGameObjectWithTag("yetersizBakiye").GetComponent<Text>();
        YetersizBakiye.enabled = false;
         PlayerPrefs.SetInt("totalCoin",50000);

    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("setCharacter") == 0)
        {
            _text.text = "Selected";
        }
        else
        {
            _text.text = "Owned";
        }
        
        if (PlayerPrefs.GetInt("character1") == 1)
        {
            _text1.text = "Owned";
        }
        else
        {
            _text1.text = "Buy";
        }

        if (PlayerPrefs.GetInt("setCharacter") == 1)
        {
            _text1.text = "Selected";
        }
        if (PlayerPrefs.GetInt("character2") == 1)
        {
            _text2.text = "Owned";
        }
        else
        {
            _text2.text = "Buy";
        }
        if (PlayerPrefs.GetInt("setCharacter") == 2)
        {
            _text2.text = "Selected";
        }
        if (PlayerPrefs.GetInt("character3") == 1)
        {
            _text3.text = "Owned";
        }
        else
        {
            _text3.text = "Buy";
        }
        if (PlayerPrefs.GetInt("setCharacter") == 3)
        {
            _text3.text = "Selected";
        }
        
        _text4.text = "x" + PlayerPrefs.GetInt("totalCoin");
    }
}
