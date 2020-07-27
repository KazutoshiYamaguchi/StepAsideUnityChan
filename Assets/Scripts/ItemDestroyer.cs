using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour {



	private GameObject carpre;
	private GameObject conepre;
	private GameObject coinpre;
    private GameObject camera;
	// Use this for initialization
	void Start () {
		
		this.camera = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {

		this.conepre = GameObject.Find("TrafficConePrefab(Clone)");
		this.carpre = GameObject.Find("CarPrefab(Clone)");
		this.coinpre = GameObject.Find("CoinPrefab(Clone)");

		if (conepre)
		{
			if (this.conepre.transform.position.z < camera.transform.position.z)
			{
				Destroy(this.conepre.gameObject);
			}
        }
        else
        {
			Debug.Log("No ConePrefab");
		}

		if (carpre)
		{
			if (this.carpre.transform.position.z < camera.transform.position.z)
			{
				Destroy(this.carpre.gameObject);
			}
		}
        else
        {
			Debug.Log("No CarPrefab");
		}

		if (coinpre)
		{
			if (this.coinpre.transform.position.z < camera.transform.position.z)
			{
				Destroy(this.coinpre.gameObject);
			}
		}
        else
        {
			Debug.Log("No CoinPrefab");
		}
		

	}
}
