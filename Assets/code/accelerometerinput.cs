using UnityEngine;
using System.Collections;

public class accelerometerinput : MonoBehaviour {
	public float gravity; // gravity applied
	public float translation_speed_factor; // speed of hero movement
	public float rotation_speed; // speed of hero turning
	public Transform hero; 
	private Animator animator; // the Mecanim controller
	private CharacterController character_controller; 
	private Vector3 move_direction;
	private float up_down_ctrl;
	public Texture img;
	public GUISkin accel;
	public GUISkin time1;
	private bool move=false;
	private bool toggle=true;
	private bool time =false;
	public float leveltime;
	public int level;
	private int cnt=0;
	//private float starttime;
	private float timeremaining=0f;
	//public AudioClip runsound;
	// Use this for initialization
	void Start () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep; 
		animator = hero.GetComponent<Animator>(); // get the component of the Mecanim controller
		character_controller = hero.GetComponent<CharacterController>();


	}

	void OnGUI(){
		GUI.skin = accel;
		if(move==false)
		{
				if (GUI.Button(new Rect (Screen.width  - 300, Screen.height -300, 250, 250),"RUN")) {
			move=move^toggle;
			    
				time=true;  
				cnt++;
				if(cnt==1)
				{
					leveltime = leveltime +Time.time;
				}

			}
		} 

		if (move == true) {
						if (GUI.Button (new Rect (Screen.width - 300, Screen.height - 300, 250, 250), "STOP")) {
								move = move ^ toggle;
				
				
						}
				} 

						if (time == true) {
						GUI.skin = time1;
								if (timeremaining < 0) {
										Application.LoadLevel (level);
								} else {
										timeremaining = leveltime - Time.time;
				
				
										GUI.Button (new Rect (10, 10, 150, 70), timeremaining.ToString ("0"));
								}
						}
				} /*else {
/*else {


						up_down_ctrl = 1;
				}*/
	
	

	
	// Update is called once per frame
	void Update () {	

		if (move == true) {
						up_down_ctrl = 1;
				} else {
						up_down_ctrl = 0;
				}
		float left_right_ctrl = Input.acceleration.x; 
		animator.SetFloat("rotation", Mathf.Abs(left_right_ctrl)); // set Mecanim's rotation variable to the absolute value of GetAxis
		animator.SetFloat("translation", Mathf.Abs(up_down_ctrl));

		move_direction.y -= gravity * Time.deltaTime; // apply gravity per second
		
		character_controller.Move(move_direction * Time.deltaTime);
		if (character_controller.isGrounded) // is the hero currently touching the ground?
		{

			move_direction = new Vector3(0, 0, up_down_ctrl); // move the character back and forth on the Z axis*
			move_direction = hero.TransformDirection(move_direction); // make the movement relative to the character and not the world
			move_direction *= translation_speed_factor;
		

		}
		float rotation_amount = left_right_ctrl * rotation_speed;
		rotation_amount *= Time.deltaTime;
		hero.Rotate(0, rotation_amount, 0); 
	
	}
}


