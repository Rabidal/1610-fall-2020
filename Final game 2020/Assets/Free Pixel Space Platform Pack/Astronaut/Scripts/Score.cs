using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

    private float _timeLeft = 30;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;
    
    
    void Update()
    {
        _timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left:" + (int)_timeLeft);
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Score:" + playerScore);
        if (_timeLeft<0.1f)
        {
            SceneManager.LoadScene("First");
        }
    }

     void OnTriggerEnter2D(Collider2D trig)
    {
        Debug.Log("Level Complete");
        CountScore();
    }

     void CountScore()
     {
         playerScore = (int) (playerScore + (_timeLeft * 10));
         Debug.Log(playerScore);
     }

     private void OnTriggerEnter(Collider other)
     { 
         Destroy(gameObject);
         playerScore++;
         print(playerScore);
     }
}
