using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRUMovement : MonoBehaviour
{
    public Transform goal; 
    public float speed = 5f;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, goal.position, speed * Time.deltaTime);
    }

    public float GetTravelTime()
    {
        float distance = Vector3.Distance(transform.position, goal.position);
        return distance / speed;
    }
}

