using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	public GameObject doors;
	public GameObject key;
	public Vector3 door_rot;
	private Vector3 totalrotation;
	private bool end=false; 
	private float degreepersecond=30f;
	public AudioClip doorsound;
	// Use this for initialization
	void Start () {
		totalrotation.y = 0.1f;
	
	}
	
	void OnTriggerEnter(Collider coll) {
		if (coll.tag=="Player"&&!key.activeInHierarchy)

		{   GetComponent<AudioSource>().clip=doorsound;
			GetComponent<AudioSource>().Play();
			end=true;
		}
	}

	void SwingOpen()
	{
				doors.transform.rotation = Quaternion.Euler (totalrotation);
		       
 		}
	// Update is called once per frame
	void Update () {
			if(end)
			if(totalrotation.y<=door_rot.y)
			{
				SwingOpen();
			     
				totalrotation.y+= Time.deltaTime*degreepersecond;
			}
		   
	}
}
