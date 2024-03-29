﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel; //game over sahne objesini buraya tanimliyoruz
    public GameObject pausePanel;
    
    //GameOver metodunu simdilik sahne aktivasyonu icin kullaniyoruz
   public void GameOver(){
       
       gameOverPanel.SetActive(true);

   }

   //Restart metodunu unity consolodan RestartButon a onClick olarak atadik.
   public void Restart(){

     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Aktif sahneyi yani HammerSmash sahnesini getiriyo.
   }

   public void Pause(){
       pausePanel.SetActive(true);
       Time.timeScale = 0f;
   }


   public void Resume(){
       pausePanel.SetActive(false);
       Time.timeScale = 1f;
   }
}

