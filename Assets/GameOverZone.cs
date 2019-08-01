using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverZone : MonoBehaviour
{
//herní objekt pod obrazovkou, který když přijde do kolize s hráčem, hra skončí

    public Controller gameController;

    private GameObject GameOverZoneObj;


    void OnTriggerEnter2D(Collider2D collider)
    {

        if(collider.name.StartsWith("player"))
        {
            gameController.isGameOver = true;
        }
    }

    void FixedUpdate()
    {
        if(GameOverZoneObj != null){
        GameOverZoneObj.transform.position = new Vector2(0, gameController.rigb2d.position.y - 100);
        }
    }

}
