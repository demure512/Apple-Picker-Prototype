using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject applePrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float chanceForChangeDirection = 0.1f;

    public float secondsBetweenAppleDrops = 1f;

    //drop apples
    void Start()
    {
      
    }

    //dirction and movement
    void Update()
    {
        //movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            //turn right
            speed = Mathf.Abs(speed); 
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); 
            //turn left
        }
    }

    void FixedUpdate()
    {
        if (Random.value < chanceForChangeDirection)
        {
            speed *= -1; //change direction
        }
    }

}
