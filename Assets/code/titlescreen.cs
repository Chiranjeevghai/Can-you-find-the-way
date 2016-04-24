using UnityEngine;
using System.Collections;

public class titlescreen : MonoBehaviour {
	public Vector3 door_rot;
	private Vector3 totalrotation;
	private float degreepersecond=60f;
	// Use this for initialization
	void Start () {
		totalrotation.x= 0f;

	}
	void SwingOpen()
	{
		transform.rotation = Quaternion.Euler (totalrotation);
		
	}
	// Update is called once per frame
	void Update () {
		if(totalrotation.x<=door_rot.x)
		{
			SwingOpen();
			
			totalrotation.x+= Time.deltaTime*degreepersecond;
		}
	}
}
