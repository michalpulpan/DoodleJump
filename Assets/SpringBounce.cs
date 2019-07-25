using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringBounce : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            SoundManagerScript.PlaySound("trampoline");
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 1300f);

        }

    }
}
