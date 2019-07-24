using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverZone : MonoBehaviour
{

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
