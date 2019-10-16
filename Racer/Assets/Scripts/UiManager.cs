using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
 
    public static int score;
    float delayTimer = 0.0f;

    void Start(){
      score = 0;
    }
    
    void Update(){

      
      if (delayTimer > 1.0f){
         score = score + 1;
         delayTimer = 0;
     }
      delayTimer += UnityEngine.Time.deltaTime;  
       
    }

    public void pause(){
      if( Time.timeScale == 1 ){
          Time.timeScale = 0; // game is paused
      }else if( Time.timeScale == 0){
          Time.timeScale = 1; // game is resumed
      }   
    }

    public void play(){
        //Application.LoadLevel("game");
        SceneManager.LoadScene("game");
    }
}
