using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTimeBounce : MonoBehaviour
{
//kolize s hnědou  platofrmou
    public bool used = false;
    public Sprite oneTimePlatform4;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0 && !used)
        {

            SoundManagerScript.PlaySound("lomise");
            SoundManagerScript.PlaySound("jump");
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 900f);
            used = true;
            this.GetComponent<SpriteRenderer>().sprite = oneTimePlatform4;

        } else if(used){
            foreach(Collider2D c in GetComponents<Collider2D>()){
                c.enabled = false;
            }
        }

    }
}
