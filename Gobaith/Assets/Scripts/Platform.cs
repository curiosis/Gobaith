using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Transform position1, position2, startPosition;
    public float speed;
    Vector3 nextPosition;

    void Start()
    {
        nextPosition = startPosition.position;
    }

    void Update()
    {
        if (transform.position == position1.position)
            nextPosition = position2.position;
        else if (transform.position == position2.position)
            nextPosition = position1.position;

        transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime);
    }
}
