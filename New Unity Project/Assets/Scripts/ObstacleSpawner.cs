﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    public float spawnTime = 1;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        if(timer > spawnTime){ 
            int rand = Random.Range(0, obstaclePrefab.Length);

            GameObject obs = Instantiate(obstaclePrefab[rand]);
            obs.transform.position = transform.position + new Vector3(0, 0, 0);
            Destroy(obs, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
