using UnityEngine;
using System.Collections;

public class titlescreentimer : MonoBehaviour {

	private float delay=5.0f;
	//public int scene;
	
	// Use this for initialization
	void Start () {
		delay = Time.time + delay;
		
		
	}
	
	
	// Update is called once per frame
	void Update () {
				if (Time.time >= delay) {
			
						Application.LoadLevel (1);
				}
		}

}
