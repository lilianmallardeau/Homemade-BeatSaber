﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] spawnPoints;
    [SerializeField][Range(0, 10)] private float beat;
    private float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat)
        {
            GameObject cube = Instantiate(cubes[Random.Range(0, cubes.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)]);
            //cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward, Random.Range(0, 4)*90);
            timer -= beat;
        }

        timer += Time.deltaTime;
    }
}