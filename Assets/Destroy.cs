using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
//skript ovládající herní objekt přesouvající platformy a příšery

    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPlatformPrefab;

    public GameObject oneTimePlatform;
    private GameObject myPlat;

    public GameObject monsterObject;

    public void OnTriggerEnter2D(Collider2D collision)
    {

        //kolize se zelenou platofrmou
        if(collision.gameObject.name.StartsWith("platform")) 
        {
            
            if (Random.Range(1, 7) == 1)
            {
                //přesune zelenou platformu
                collision.gameObject.transform.position = new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f)));

            } else if (Random.Range(1, 7) == 2)
            {
                //zničí zelenou platformu a vytvoří modrou
                Destroy(collision.gameObject);
                Instantiate(springPlatformPrefab, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            }  else {
                //zničí zelenou platformu a vytvoří hnědou
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            }
        }
        //kolize s modrou platofrmou
        else if(collision.gameObject.name.StartsWith("spring"))
        {

            if (Random.Range(1, 7) == 1)
            {
                //přesune modrou platformu
                collision.gameObject.transform.position = new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f)));

            } else if (Random.Range(1, 7) == 2)
            {
                //zničí modrou platformu a vytvoří zelenou
                Destroy(collision.gameObject);
                Instantiate(oneTimePlatform, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            }  else {
                //zničí modrou platformu a vytvoří hnědou
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            }

        }
        //kolize s hnědou platofrmou
        else if(collision.gameObject.name.StartsWith("oneTime"))
        {

            if (Random.Range(1, 7) == 1)
            {
                //zničí hnědou platformu a vytvoří hnědou
                Destroy(collision.gameObject);
                Instantiate(oneTimePlatform, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            } else if (Random.Range(1, 7) == 2)
            {
                //zničí hnědou platformu a vytvoří hnědou
                Destroy(collision.gameObject);
                Instantiate(oneTimePlatform, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            }  else {
                //zničí hnědou platformu a vytvoří zelenou
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (16 + Random.Range(0.2f, 1.0f))), Quaternion.identity);

            }  

        }

        //kolize s příšerou
        if(collision.gameObject.name.StartsWith("Monster")){
            Destroy(collision.gameObject);
            Instantiate(monsterObject, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (Random.Range(22, 55))), Quaternion.identity);
        }
        
    }


}
