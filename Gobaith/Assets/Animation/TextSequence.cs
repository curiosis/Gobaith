using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSequence : MonoBehaviour
{
	public GameObject camera;
	public GameObject gobaith;
	public GameObject hope;
	public GameObject nadzieja;
	public GameObject Cam2;
	public float time = 0.0f;
	
    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;
		if(time >= 1f)
			gobaith.gameObject.SetActive(true);
		
		if(time >= 3f)
			hope.gameObject.SetActive(true);
		
		if(time >= 5f)
			nadzieja.gameObject.SetActive(true);
		
		if(time >= 7f)
		{
			camera.gameObject.SetActive(false);
			Cam2.gameObject.SetActive(true);
		}
    }
}
