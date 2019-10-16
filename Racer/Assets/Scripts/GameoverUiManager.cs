using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameoverUiManager : MonoBehaviour
{
    
    public Text scoreText;

    void Start(){
       scoreText.text = scoreText.text + (UiManager.score).ToString();
    }
    
    void Update(){
         
    }

    public void play(){
        //Application.LoadLevel("game");
        SceneManager.LoadScene("game");
    }

    public void quit(){
        Application.Quit();
    }
}
