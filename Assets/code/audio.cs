using UnityEngine;
using System.Collections;

public class audio : MonoBehaviour {
	public AudioClip tune;
	// Use this for initialization
	void Start () {
		GetComponent<AudioSource>().clip = tune;
		GetComponent<AudioSource>().loop = true;
		GetComponent<AudioSource>().Play ();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
