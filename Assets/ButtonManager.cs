using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{



    public void StartGame(){

        SceneManager.LoadScene("Game");
    }

    public void PauseGame(){

        if(Time.timeScale == 1){
            Time.timeScale = 0;
            SceneManager.LoadScene("PauseMenu",LoadSceneMode.Additive);
        }else{
            Time.timeScale = 1;
            SceneManager.UnloadScene("PauseMenu");

        }

    } 

    public void ResumeGame(){

        Time.timeScale = 1;
        SceneManager.UnloadScene("PauseMenu");
    }

    public void RestartGame(){

        Time.timeScale = 1;
        //SceneManager.UnloadScene("PauseMenu");
        SceneManager.LoadScene("Game");

    }


}
