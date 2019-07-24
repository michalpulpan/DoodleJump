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

    private float topScore = 0.0f;

    public Text scoreText;

    public bool isGameOver = false;

    public ButtonManager btnMngr;
    

    void Start()
    {
        rigb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
   {
       if(moveInput <0)
       {
           this.GetComponent<SpriteRenderer>().flipX = false;
       }
       else
       {
           this.GetComponent<SpriteRenderer>().flipX = true;
       }

       if (rigb2d.velocity.y > 0 && transform.position.y > topScore){

           topScore = transform.position.y;
       }

       scoreText.text = Mathf.Round(topScore).ToString();

       if(isGameOver == true){
           isGameOver = false;
            SceneManager.LoadScene("GameOver");
       }
   } 

    void FixedUpdate()
    {
            //scoreText.transform.position = new Vector2(100f,10f);
            moveInput = Input.GetAxis("Horizontal");
            rigb2d.velocity = new Vector2(moveInput * speed, rigb2d.velocity.y);



    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "leftColl" || other.gameObject.name == "rightColl"){

            transform.position = new Vector2(transform.position.x/Mathf.Abs(transform.position.x)-transform.position.x,transform.position.y);

        }
    }
}
