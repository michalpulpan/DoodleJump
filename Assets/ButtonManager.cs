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

        //zmrazí hru
        if(Time.timeScale == 1){
            Time.timeScale = 0;
            SceneManager.LoadScene("PauseMenu",LoadSceneMode.Additive);
        }else{
            Time.timeScale = 1;
            SceneManager.UnloadScene("PauseMenu");

        }

    } 

    public void ResumeGame(){

        //rozmrazí hru
        Time.timeScale = 1;
        SceneManager.UnloadScene("PauseMenu");
    }

    public void RestartGame(){

        //rozmrazí hru a zapne ji znovu
        Time.timeScale = 1;
        //SceneManager.UnloadScene("PauseMenu");
        SceneManager.LoadScene("Game");

    }


}
