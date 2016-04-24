using UnityEngine;
using System.Collections;

public class PointCollector : MonoBehaviour {

	public AudioClip end_game;

	public ParticleSystem essence;
	private float degreepersecond=45f;
	private Vector3 keyrotation;

	private bool collected;

	void Start()
	{
		essence.Clear();
		essence.Stop();
	}

	void OnTriggerEnter(Collider coll) {
		if (coll.tag=="Player" && !collected)
		{
			StartCoroutine(BallCollected());
			collected = true;
		}
	}

	IEnumerator BallCollected()
	{
		GetComponent<AudioSource>().clip = end_game;
		GetComponent<AudioSource>().Play();
		GetComponent<Renderer>().material.color = Color.black;
		yield return new WaitForSeconds(2.0f);
		essence.Play();
		Destroy(transform.gameObject);
	
	}
	void Update()
	{
				transform.rotation = Quaternion.Euler (keyrotation);
				keyrotation.y += Time.deltaTime * degreepersecond;
    }




}