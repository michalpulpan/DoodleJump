using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPlatformPrefab;
    private GameObject myPlat;

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if(Random.Range(1,6)>1)
        {
            myPlat= (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f,5.5f), player.transform.position.y + (16 + Random.Range(0.5f,1f))), Quaternion.identity);
        } 
        else 
        {

        myPlat= (GameObject)Instantiate(springPlatformPrefab, new Vector2(Random.Range(-5.5f,5.5f), player.transform.position.y + (16 + Random.Range(0.5f,1f))), Quaternion.identity);
         
        }
        Destroy(collision.gameObject);
    }
}
