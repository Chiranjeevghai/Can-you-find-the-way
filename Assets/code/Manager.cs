using UnityEngine; // unity's collection of scripts
using System.Collections; // microsoft's scripts, including coroutines (special type of functions)

public class Manager : MonoBehaviour // class must have the same name as file, also we are extending the monobehaviour class
{
	public float translation_speed_factor; // speed of hero movement
	public float rotation_speed; // speed of hero turning
	//public float jump_speed; // jump height
	public float gravity; // gravity applied
	//public AudioClip runsound;

	public Transform hero; // our main character to be assigned in Editor
	//public Transform env_sphere; // the environment sphere
	//public AudioClip jump_sound; // sound to play on jump

	private Vector3 move_direction; // character movement in space 

	private Animator animator; // the Mecanim controller
	private CharacterController character_controller; // the character movement controller

	void Start() // this is called on the frame the script is enabled
	{
		animator = hero.GetComponent<Animator>(); // get the component of the Mecanim controller
		character_controller = hero.GetComponent<CharacterController>(); // get the component of the Character Controller
		//hero.audio.clip = runsound;
		//env_sphere.gameObject.SetActive(true); // enable the environment sphere
	}



	void Update() //this is called on every frame
	{

		float up_down_ctrl = Input.GetAxis("Vertical"); // assign a float variable that goes from -1 to 1 for movement
		float left_right_ctrl = Input.GetAxis("Horizontal"); // assign a float variable that goes from -1 to 1 for turning
		
		animator.SetFloat("rotation", Mathf.Abs(left_right_ctrl)); // set Mecanim's rotation variable to the absolute value of GetAxis
		animator.SetFloat("translation", Mathf.Abs(up_down_ctrl)); // set Mecanim's translation variable to the absolute value of GetAxis
		move_direction.y -= gravity * Time.deltaTime; // apply gravity per second
		
		character_controller.Move(move_direction * Time.deltaTime); // character controller's movement function implemented with our controls
		if (Input.GetKeyDown (KeyCode.W))
		{
			//hero.audio.loop=true;
			//hero.audio.Play();
			
		}
		if(Input.GetKeyUp(KeyCode.W))
		   {
			//hero.audio.Stop();
		     }
		if (character_controller.isGrounded) // is the hero currently touching the ground?
		{

		    move_direction = new Vector3(0, 0, up_down_ctrl); // move the character back and forth on the Z axis*
			move_direction = hero.TransformDirection(move_direction); // make the movement relative to the character and not the world
			move_direction *= translation_speed_factor; // multiply the -1 to 1 value by our factor
				

		/*	if (Input.GetButton("Jump")) // if the jump button in the player settings is pressed
			{
				move_direction.y = jump_speed; // set the jump speed
				animator.Play("jump"); // play the jump animation once
				audio.clip = jump_sound; // set the sound that we want to play
				audio.Play(); // play the sound

			}*/

		} 

		// Rotation :
		// Multiplies the -1 to 1 GetAxis value by the public rotation_speed variable so we can change it in the editor 
		float rotation_amount = left_right_ctrl * rotation_speed;
  		rotation_amount *= Time.deltaTime;
		hero.Rotate(0, rotation_amount, 0); // ...and finally rotates the hero


	}



}

