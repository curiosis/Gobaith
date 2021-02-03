using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int speed;
    public bool rotate;

    void Update()
    {
        if(rotate)
            transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
