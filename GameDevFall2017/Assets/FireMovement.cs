using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMovement : MonoBehaviour
{
	private Rigidbody2D rb;

	public float forceStrength = 100.0f;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetAxis("Horizontal") > 0 )
			
		{
			// right
		}
		
		if (Input.GetAxis("Horizontal") < 0 )
			
		{
			// left
		}


		if (Input.GetAxis("Vertical") > 0)
		{
			// up
			rb.AddForce(Vector2.up * forceStrength);
		}
		
		if (Input.GetAxis("Vertical") < 0)
		{
			// down
		}

//		if (Input.GetKeyDown(KeyCode.I))
//		{
//			// move up 
//			Debug.Log("pressed up");
//			//transform.Translate(Vector2.up *2);
//			//rb.MovePosition(Vector2.up * 2);
//			rb.AddForce(Vector3.up * forceUp);
//			
//		}if (Input.GetKey(KeyCode.K))
//		{
//			// move down
//			//transform.Translate(Vector2.down * 2);
//			
//			
//		}if (Input.GetKey(KeyCode.J))
//		{
//			// move left
//			//transform.Translate(Vector2.left * 2);
//			rb.AddForce(Vector3.left * forceUp);
//			
//			
//		}if (Input.GetKey(KeyCode.L))
//		{
//			// move right 
//			rb.AddForce(Vector3.right * forceUp);
//			
//			
//		}

	}
}
