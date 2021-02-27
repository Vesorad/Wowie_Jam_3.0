using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromPointToPoint : MonoBehaviour
{
    public Transform[] points;
    int pathIndex = 0;



    public int speed = 10;

    void Update()
    {
        var targetPos = points[pathIndex].transform.position;
        var movementThisFrame = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, targetPos, movementThisFrame);
        if (transform.position == targetPos)
        {
            if (pathIndex== points.Length-1)
            {
                pathIndex = 0;
            }
            else
            {
                pathIndex++;
            }
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name =="Player")
        {
            gameObject.SetActive(false);
        }
    }
}
