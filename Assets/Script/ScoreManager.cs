    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using TMPro;
    public class ScoreManager : MonoBehaviour
    {
        int currentScore;
        public int totalScore;
        public TMP_Text scoreText;
    public GameManager gameManager;
        // Start is called before the first frame update
        void Start()
        {
            currentScore = 0;
            DisplayScore();
        }
        public void CollectCollectible()
        {
            currentScore++;
            DisplayScore();
            if(currentScore >= totalScore)
            {
                gameManager.GameWon();
            }
       
        }

         public void DisplayScore()
        {
            scoreText.text = currentScore + " / " + totalScore;
            Debug.Log("current score is " + currentScore + " out of " + totalScore);
        
        }
    }
