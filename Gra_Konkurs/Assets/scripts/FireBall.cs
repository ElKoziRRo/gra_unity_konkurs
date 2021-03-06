﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour {

    private GameMaster gm;
    private GameObject player;
    private GameObject enemies;

    private Rigidbody2D myBody;
    private float speed = 20f;

    

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<GameObject>();
        enemies = GameObject.FindGameObjectWithTag("Enemy").GetComponent<GameObject>();
    }

    void FixedUpdate()
    {
        myBody.velocity = new Vector2(speed, 0);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Enemy"))
        {
            Destroy(this);
            gm.PlaySound("DamageEnemy");//add music, ect
        }
    }
}
