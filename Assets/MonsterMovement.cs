using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{

    public int leftRight;
    public bool switchUp;
    public float speed;
    public float maxX;
    public float speedMin;
    public float speedMax;

    public GameObject monster;

    public GameObject player;


    void OnEnable()
    {
        leftRight = Random.Range(0,2);
        if(leftRight == 1){
            switchUp = true;
        } else {
            switchUp = false;
        }
        speed = Random.Range(speedMin, speedMax);
    }

    void Update(){
        MovementFunction();
    }

    void MovementFunction()
    {
        if(monster.transform.position.x >= maxX && switchUp == true){
            switchUp = false;
            leftRight = 0;
        } else if(monster.transform.position.x <= -maxX && switchUp == false){
            switchUp = true;
            leftRight = 1;
        } 
        else if(leftRight == 0){
            

            monster.transform.Translate(new Vector3(-speed,0,0)*Time.deltaTime);
        }
        else if(leftRight == 1){
                       

            monster.transform.Translate(new Vector3(speed,0,0)*Time.deltaTime);  
        }
    }

    
}
