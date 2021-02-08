using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrapplinghook : MonoBehaviour
{
    public static bool spawn;
    public GameObject grapplingHook;

    void Update()
    {
        if (spawn)
        {
            grapplingHook.SetActive(true);
            spawn = false;
        }
            
    }
}
