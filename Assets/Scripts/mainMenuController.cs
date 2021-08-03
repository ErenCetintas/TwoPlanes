using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenuController : MonoBehaviour
{   
    public GameObject PausedText;
    bool isPaused = false;
    

    // Start is called before the first frame update
    void Start()
    {
        PausedText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playButton(){
        SceneManager.LoadScene("inGame");
        Debug.Log("--------------------------------------------");
        //plane sound
        FindObjectOfType<soundManager>().Play("Plane");
    }
    public void pauseButton(){
        if(isPaused){
            Time.timeScale = 1;
            isPaused = false;
            PausedText.SetActive(false);
        }
        else{
            Time.timeScale = 0;
            isPaused = true;
            PausedText.SetActive(true);
        }        
        
    }
    public void exitButton(){
         Application.Quit();
    }
    public void DantGamesPage(){
         Application.OpenURL("https://play.google.com/store/apps/dev?id=7505620708147092978");
    }

}
