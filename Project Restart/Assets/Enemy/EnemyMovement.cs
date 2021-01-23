﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform playerModel;
    CharacterController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        playerModel = playerGameObject.transform;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = playerModel.position - transform.position;
        controller.Move(direction * Time.deltaTime);

    }
}
