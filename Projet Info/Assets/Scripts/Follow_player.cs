﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_player : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 offset;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
