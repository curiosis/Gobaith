using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSequence : MonoBehaviour
{
    public GameObject Player;
	public GameObject Cam1;
	public GameObject Cam2;
	public float time=0.0f;
	
    void Start()
    {
    }
	
	void Update()
    {
		time += Time.deltaTime;
		if(time >= 9f)
		{
			Player.gameObject.SetActive(true);
		}
		
		if(time >= 11.35f) //dopasowac jeszcze
		{
			Cam1.gameObject.SetActive(false);
		}
		
		if(time >= 25.0f)
		{
			Player.gameObject.SetActive(false);
			Cam2.gameObject.SetActive(true);
		}
	}

}
