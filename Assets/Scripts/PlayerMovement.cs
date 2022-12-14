using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	[SerializeField] private int WalkSpeed;
	[SerializeField] private int RunSpeed;
	[SerializeField] private float sensitivity;
	[SerializeField] private float JumpForce;
	[SerializeField] private int minAngle;
	[SerializeField] private int maxAngle;

	private bool isRunning;
	private Camera cam;
	private Rigidbody rb;
	private Transform player;
	private float xAngle = 0, yAngle = 0;
	private int speed;
	private bool focused;

	void Start() 
	{
		rb = GetComponent<Rigidbody>();
		cam = GetComponent<Camera>();
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		focused = true;
		speed = WalkSpeed;
	}

    // Update is called once per frame
    void Update()
    {

    }

	void FixedUpdate() 
	{
		Rotate();
		Move();
	}

	private void Move() 
	{
		float xMove = (float)((Input.GetKey(KeyCode.D) ? 1 : 0) - (Input.GetKey(KeyCode.A) ? 1 : 0));
		float zMove = (float)((Input.GetKey(KeyCode.W) ? 1 : 0) - (Input.GetKey(KeyCode.S) ? 1 : 0));
		bool jump = Input.GetKeyDown(KeyCode.Space) && isGrounded();

		Vector3 velocity = new Vector3(xMove, rb.velocity.y, zMove) * speed;
		velocity = cam.transform.TransformDirection(velocity);
     	velocity.y = 0f;
		rb.velocity = velocity;

		rb.AddForce(new Vector3(0, jump ? 10 : -10, 0), ForceMode.Acceleration);

	}

	private void Rotate() 
	{
		if (focused) {
			yAngle += Input.GetAxis("Mouse X") * sensitivity;
			xAngle += Input.GetAxis("Mouse Y") * sensitivity;

			xAngle = Mathf.Clamp(xAngle, minAngle, maxAngle);

			transform.localEulerAngles = new Vector3(0, yAngle, 0);
			cam.transform.localEulerAngles = new Vector3(-xAngle, yAngle, 0);

			if (Input.GetKeyDown(KeyCode.Escape))
			{
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
				focused = false;
			}
		}
		else if (Input.GetMouseButtonDown(0))
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			focused = true;
		}
	}

	private bool isGrounded() {
		return true;
	}
}
