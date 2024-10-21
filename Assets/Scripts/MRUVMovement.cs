using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRUVMovement : MonoBehaviour
{
    public Transform goal;
    public float initialSpeed = 2f;
    public float acceleration = 0.5f;
    private float currentSpeed;

    void Start()
    {
        currentSpeed = initialSpeed;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, goal.position, currentSpeed * Time.deltaTime);
        currentSpeed += acceleration * Time.deltaTime;
    }

    public void AdjustParameters(float goalTime)
    {
        float distance = Vector3.Distance(transform.position, goal.position);
        acceleration = 2 * (distance - initialSpeed * goalTime) / (goalTime * goalTime);
        currentSpeed = initialSpeed;
    }
}

