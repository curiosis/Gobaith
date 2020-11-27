using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSequence : MonoBehaviour
{
	public GameObject camera;
	public GameObject gobaith;
	public GameObject hope;
	public GameObject nadzieja;
	public GameObject hoffnung;
	public GameObject esperanza;
	public GameObject espérer;
	public GameObject hадежда;
	public GameObject eλπίδα;
	public GameObject umut;
	public GameObject speranza;
	public GameObject itxaropena; 
	public GameObject hадеж;
	public GameObject naděje;
	public GameObject håber;
	public GameObject hoop;
	public GameObject nada;
	public GameObject spe;
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
		
		if(time >= 9f)
			hoffnung.gameObject.SetActive(true);
		
		if(time >= 9.4f)
			esperanza.gameObject.SetActive(true);
		
		if(time >= 9.8f)
			espérer.gameObject.SetActive(true);
		
		if(time >= 10.2f)
			hадежда.gameObject.SetActive(true);
		
		if(time >= 10.6f)
			eλπίδα.gameObject.SetActive(true);
		
		if(time >= 11f)
			speranza.gameObject.SetActive(true);
		
		if(time >= 11.4f)
			itxaropena.gameObject.SetActive(true);
		
		if(time >= 11.8f)
			hадеж.gameObject.SetActive(true);
		
		if(time >= 12.2f)
			naděje.gameObject.SetActive(true);
		
		if(time >= 12.6f)
			håber.gameObject.SetActive(true);
		
		if(time >= 13f)
			hoop.gameObject.SetActive(true);
		
		if(time >= 13.4f)
			nada.gameObject.SetActive(true);
		
		if(time >= 13.8f)
			spe.gameObject.SetActive(true);
    }
}
