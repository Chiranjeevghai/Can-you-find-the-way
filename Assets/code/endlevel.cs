using UnityEngine;
using System.Collections;

public class endlevel : MonoBehaviour {
	public string point;
	public int level;
	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt (point, 0);
	}	

	void OnTriggerEnter(Collider coll) {
		if (coll.tag=="Player" )
		{   PlayerPrefs.SetInt (point, 1);
			PlayerPrefs.Save();
			PlayerPrefs.SetInt("loadlevel",level);
			Application.LoadLevel(3);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
