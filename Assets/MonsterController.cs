using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MonsterController : MonoBehaviour
{
//skript ovládající kolize hráče s příšerou
    public Controller gameController;
    public Sprite MonsterDead;

    public bool isActive = true;


    void OnTriggerEnter2D(Collider2D collider)
    {

        if(collider.gameObject.GetComponent<Rigidbody2D>().velocity.y <= -3 && isActive)
        {
            //odraz od příšery a její zabití
            collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 900f);
            this.GetComponent<SpriteRenderer>().sprite = MonsterDead;
            var defPostion = transform.position.y;
            isActive = false;
           

        } else if(collider.name.StartsWith("player") && isActive)
        {
            SceneManager.LoadScene("GameOver");
            SoundManagerScript.PlaySound("gameOver");
        }
    }


}
