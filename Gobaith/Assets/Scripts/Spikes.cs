using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public Transform position1, position2, startPosition;
    public float speed, stopSpeed;
    Vector3 nextPosition;

    void Start()
    {
        nextPosition = startPosition.position;
    }


    void Update()
    {
        if (transform.position == position1.position)
        {
            nextPosition = position2.position;
            transform.position = Vector3.MoveTowards(transform.position, nextPosition, (speed * Time.deltaTime)/2);
            
        }
        else if (transform.position == position2.position)
        {
            nextPosition = position1.position;
            Stop();
            transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime);
        }

        
    }

    IEnumerator Stop()
    {
        yield return new WaitForSeconds(stopSpeed);
    }
}
