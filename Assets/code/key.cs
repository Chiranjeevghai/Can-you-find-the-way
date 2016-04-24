using UnityEngine;
using System.Collections;

public class key : MonoBehaviour {
	public bool keycollected=false;
	private float degreepersecond=45f;
	private Vector3 keyrotation;
	public ParticleSystem essence;
	public AudioClip end_game;
	public GameObject keys;
	// Use this for initialization
	void Start () {
		essence.Clear();
		essence.Stop();
	}



	void Update () {
		transform.rotation = Quaternion.Euler (keyrotation);
		keyrotation.y+= Time.deltaTime*degreepersecond;
		
	}
	void OnTriggerEnter(Collider coll) {
				if (coll.tag == "Player"&&keycollected==false) {
			       
			keys.GetComponent<AudioSource>().clip=end_game;
			keys.GetComponent<AudioSource>().Play();	
			
			keycollected=true;
			essence.Play();
			//yield return new WaitForSeconds(2.0f);
			gameObject.SetActive(false);
		}}


}
