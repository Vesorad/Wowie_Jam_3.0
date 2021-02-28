using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drabina : MonoBehaviour
{
    public Vector3[] pos;
    int pathIndex = 0;

    public int speed=10;
    void Start()
    {
       
    }

    
    void Update()
    {
        var targetPos = pos[pathIndex];
        var movementThisFrame = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, targetPos, movementThisFrame);
        if (transform.position == targetPos)
        {
            if (pathIndex == pos.Length - 1)
            {
                pathIndex = 0;
            }
            else
            {
                pathIndex++;
            }

        }
    }
}
