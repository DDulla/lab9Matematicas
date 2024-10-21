using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public float speed = 2f; 
    public float acceleration = 5f; 
    public float stopDistance = 1f;
    public Transform objective; 
    private float startTime;
    private bool hasReachedDestination = false;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        if (!hasReachedDestination && Vector3.Distance(transform.position, objective.position) > stopDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, objective.position, speed * Time.deltaTime);
            speed += acceleration * Time.deltaTime; 
        }
        else if (!hasReachedDestination)
        {
            float travelTime = Time.time - startTime;
            Debug.Log("El tiempo de viaje fue: " + travelTime);

            hasReachedDestination = true; 
        }
    }
}




