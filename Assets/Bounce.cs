using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //kolize se zelenou platofrmou
        if(collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {

            SoundManagerScript.PlaySound("jump");
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 900f);

        }

    }
}
