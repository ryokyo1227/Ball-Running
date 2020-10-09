﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpFloor : MonoBehaviour
{
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        player.Jump();
    }
}
