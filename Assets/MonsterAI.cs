using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAI : MonoBehaviour
{

    public float speed;
    public float targetDistance;

    public MonsterController mController;

    public GameObject destroyer;

    //public float xDist,yDist;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 distance = new Vector2(xDist,yDist);
        if(Vector2.Distance(transform.position,target.position)>targetDistance && mController.isActive){
            transform.position = Vector2.MoveTowards(transform.position,target.position,speed*Time.deltaTime);
        } 
    }
}
