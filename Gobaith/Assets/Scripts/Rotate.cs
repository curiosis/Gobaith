using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int speed;
    public bool rotate;
    public bool rotateSoundEffect;

    void Update()
    {
        if (rotate)
        {
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }

        if (rotateSoundEffect)
        {
            SoundManager.PlaySound("UnknownBossRotate", 0.005f);
            rotateSoundEffect = false;
        }
            

    }
}
