using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    
   
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void addScore(int point){
        score += point;
        scoreText.text = score.ToString();
    }
}
