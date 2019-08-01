using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Controller : MonoBehaviour
{

    public Rigidbody2D rigb2d;
    public float moveInput;
    private float speed = 10f;

    public static float topScore = 0.0f;

    public Text scoreText;

    public bool isGameOver = false;

    public ButtonManager btnMngr;
    

    void Start() //při spuštění
    {
        topScore = 0;
        rigb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
   {
       //otočení hlavní postavy doleva při stisku šipky
       if(moveInput <0)
       {
           this.GetComponent<SpriteRenderer>().flipX = false;
       }
       else
       {
           this.GetComponent<SpriteRenderer>().flipX = true;
       }

        //přidání skore
       if (rigb2d.velocity.y > 0 && transform.position.y > topScore){

           topScore = transform.position.y;
       }

       scoreText.text = Mathf.Round(topScore).ToString();

       if(isGameOver == true){
           isGameOver = false;
            SceneManager.LoadScene("GameOver");
            SoundManagerScript.PlaySound("gameOver");

       }
   } 

    void FixedUpdate()
    {
            //pohyb doprava a doleva
            moveInput = Input.GetAxis("Horizontal");
            rigb2d.velocity = new Vector2(moveInput * speed, rigb2d.velocity.y);
    }

}
