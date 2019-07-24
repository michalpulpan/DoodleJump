using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MonsterController : MonoBehaviour
{

    public Controller gameController;
    void OnTriggerEnter2D(Collider2D collider)
    {

        if(collider.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {

            collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 900f);

        } else if(collider.name.StartsWith("player"))
        {
            SceneManager.LoadScene("GameOver");
            //gameController.isGameOver = true;
        }
    }


}
