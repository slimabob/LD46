﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : MonoBehaviour
{
    private Rigidbody rb;
    private Transform parentTransform;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(parentTransform != null)
        {
            //transform.position = parentTransform.position;
            rb.MovePosition(parentTransform.position);
        }
    }

    public void AttachToTransform(Transform p)
    {
        rb.useGravity = false;
        rb.isKinematic = true;
        parentTransform = p;
    }

    public void Detatch()
    {
        rb.useGravity = true;
        rb.isKinematic = false;
        parentTransform = null;
    }
}