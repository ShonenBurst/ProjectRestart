﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour { 


    [SerializeField] float sensitivityY;
    public float minimumY = -30f;
    public float maximumY = 30F;
    float rotationY = 0F;
    // Start is called before the first frame update
    void Start()
    { }

    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
        transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
    }
}
