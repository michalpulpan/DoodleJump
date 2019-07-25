using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPlatformPrefab;

    public GameObject oneTimePlatform;
    private GameObject myPlat;

    public GameObject monsterObject;

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.name.StartsWith("platform"))
        {
            
            if (Random.Range(1, 7) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f)));

            } else if (Random.Range(1, 7) == 2)
            {

                Destroy(collision.gameObject);
                Instantiate(springPlatformPrefab, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            }  else {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            }
        }else if(collision.gameObject.name.StartsWith("spring"))
        {

            if (Random.Range(1, 7) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f)));

            } else if (Random.Range(1, 7) == 2)
            {

                Destroy(collision.gameObject);
                Instantiate(oneTimePlatform, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            }  else {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            }

        }else if(collision.gameObject.name.StartsWith("oneTime"))
        {

            if (Random.Range(1, 7) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(oneTimePlatform, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            } else if (Random.Range(1, 7) == 2)
            {

                Destroy(collision.gameObject);
                Instantiate(oneTimePlatform, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            }  else {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            }  

        }

        if(collision.gameObject.name.StartsWith("Monster")){
            Destroy(collision.gameObject);
            Instantiate(monsterObject, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (Random.Range(22, 55))), Quaternion.identity);
        }
        
        /*
        if(Random.Range(1,6)>1)
        {
            myPlat= (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f,5.5f), player.transform.position.y + (16 + Random.Range(0.5f,1f))), Quaternion.identity);
        } 
        else 
        {

        myPlat= (GameObject)Instantiate(springPlatformPrefab, new Vector2(Random.Range(-5.5f,5.5f), player.transform.position.y + (16 + Random.Range(0.5f,1f))), Quaternion.identity);
         
        }
        Destroy(collision.gameObject);

         */
    }


}
