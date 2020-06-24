using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("GameOverScene");
        
    }
}
