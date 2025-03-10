﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public Transform player;

    private Transform myTransform;

    private void Awake()
    {
        myTransform = transform;
    }

    public float GetDistanceToPlayer()
    {
        return Vector3.Distance(myTransform.position, player.position);
    }

    public Vector3 GetDirectionToPlayer()
    {
        return player.position - myTransform.position;
    }
}
