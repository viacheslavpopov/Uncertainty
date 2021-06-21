﻿using UnityEngine;

public class ReachDestination : Condition
{
    [SerializeField] private float offset = 2f;
    [SerializeField] private Transform center;

    private Vector3 _point = Vector3.zero;
    public void SetDestination(Vector3 dest)
    {
        _point = dest;
    }
    public override bool IsMet
    {
        get
        {
        return Vector3.Distance(center.position, _point) <= offset;
        }
    }
}