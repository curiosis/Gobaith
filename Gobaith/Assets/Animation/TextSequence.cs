using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
		if(time >= 3f)
			gobaith.gameObject.SetActive(true);
		
		if(time >= 7f)
			hope.gameObject.SetActive(true);
		
		if(time >= 11f)
			nadzieja.gameObject.SetActive(true);
		
		if(time >= 15f)
		{
			camera.gameObject.SetActive(false);
			Cam2.gameObject.SetActive(true);
		}
		if(time >= 25f)
        {
			SceneManager.LoadScene("TitleScreen");
        }
    }
}
