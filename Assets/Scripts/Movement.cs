using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform pointA; 
    public Transform pointB;
    public float velocity = 5f;
    private Vector3 direction;
    private bool movingToB = false; 

    void Start()
    {
        direction = pointA.position;
        CalculateAndLogTravelTime(transform.position, pointA.position);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, direction, velocity * Time.deltaTime);
        if (Vector3.Distance(transform.position, direction) < 0.1f)
        {
            if (movingToB)
            {
                direction = pointA.position;
            }
            else
            {
                direction = pointB.position;
            }
            CalculateAndLogTravelTime(transform.position, direction);
            movingToB = !movingToB;
        }
    }

    void CalculateAndLogTravelTime(Vector3 start, Vector3 end)
    {
        float distance = Vector3.Distance(start, end);
        float travelTime = distance / velocity;
        Debug.Log("El tiempo de viaje al siguiente punto es: " + travelTime + " segundos");
    }
}



