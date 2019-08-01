using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAI : MonoBehaviour
{
//skript ovládající pohyb příšery za hráčem
    public float speed;
    public float targetDistance;

    public MonsterController mController;

    public GameObject destroyer;

    private Transform target;

    // Příšera najde hlavní postavu
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if(Vector2.Distance(transform.position,target.position)>targetDistance && mController.isActive){
            transform.position = Vector2.MoveTowards(transform.position,target.position,speed*Time.deltaTime);
        } 
    }
}
