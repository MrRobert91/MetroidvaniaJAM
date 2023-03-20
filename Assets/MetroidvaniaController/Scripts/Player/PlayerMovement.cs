using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool dash = false;

	private bool freeze = false;

	//bool dashAxis = false;
	
	// Update is called once per frame
	void Update () {

		freeze = DialogueManager.GetInstance().dialogueIsPlaying;

		if (!freeze)
		{
			horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
			animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		}
		else {
			//m_Rigidbody2D.constraints = RigidbodyConstraints2D.FreezePosition;
			horizontalMove = 0f;
			//return;
		}

		// horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		// animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


		if (Input.GetKeyDown(KeyCode.Z))
		{
			jump = true;
		}

		if (Input.GetKeyDown(KeyCode.C))
		{
			dash = true;
		}

		/*if (Input.GetAxisRaw("Dash") == 1 || Input.GetAxisRaw("Dash") == -1) //RT in Unity 2017 = -1, RT in Unity 2019 = 1
		{
			if (dashAxis == false)
			{
				dashAxis = true;
				dash = true;
			}
		}
		else
		{
			dashAxis = false;
		}
		*/

	}

	public void OnFall()
	{
		animator.SetBool("IsJumping", true);
	}

	public void OnLanding()
	{
		animator.SetBool("IsJumping", false);
	}

	void FixedUpdate ()
	{

		freeze = DialogueManager.GetInstance().dialogueIsPlaying;

		if (!freeze)
		{
			// Move our character
			controller.Move(horizontalMove * Time.fixedDeltaTime, jump, dash);
			jump = false;
			dash = false;

		}
		else {
			Debug.Log("freeze move 0");
			controller.Move(0f, jump, dash);
			return;
		}


		// // Move our character
		// controller.Move(horizontalMove * Time.fixedDeltaTime, jump, dash);
		// jump = false;
		// dash = false;
	}
}
