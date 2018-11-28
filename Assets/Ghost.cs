using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{

    public Transform[] Waypoint;
    public int currentLocation = 0;
    public float speed = 3;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y != Waypoint[currentLocation].transform.position.y)
        {
            transform.position = Vector3.MoveTowards(transform.position, Waypoint[currentLocation].transform.position, speed * Time.deltaTime);
        }
        if (transform.position.y == Waypoint[currentLocation].transform.position.y)
        {
            currentLocation += 1;
        }
        if (currentLocation >= Waypoint.Length)
        {
            currentLocation = 0;
        }
    }
}
