﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class _ScoreManager_ : MonoBehaviour
{
    public class ScoreManager : MonoBehaviour
    {
        public int lives = 20;
        public int money = 50;

        public Text moneyText;
        public Text livesText;

        public void loseLife(int l = 1)
        {
            lives -= 1;
            if (lives <= 0)
            {
                GameOver();
            }
        }

        public void GameOver()
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        private void Update()
        {
            moneyText.text = money.ToString();
            livesText.text = lives.ToString();
        }
    }
}
