using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    public Text bestScoreText;
    
   
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
       GetBestScore();
    }

    
     void GetBestScore(){
        bestScoreText.text = PlayerPrefs.GetInt("BestScore" , 0).ToString();
    }

    public void addScore(int point){
        score += point;
        scoreText.text = score.ToString();

         if (score > PlayerPrefs.GetInt("BestScore", 0))
        {
            bestScoreText.text = score.ToString();
            PlayerPrefs.SetInt("BestScore",score);
        }
    }
}
