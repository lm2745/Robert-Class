using UnityEngine;
using System.Collections;

public class MoveTest : MonoBehaviour {

	public float moveSpeed = 5f; 
	public float turnSpeed = 15f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey ( KeyCode.W ) ) { 
			transform.position += new Vector3(0f, 0f, moveSpeed); 
		} 
		if (Input.GetKey (KeyCode.S) ) { 
			transform.Translate ( new Vector3(0f, 0f, 1f) ); 
		}  
		if (Input.GetKey (KeyCode.A) ) { 
			transform.eulerAngles += new Vector3(0f, 5f, 0f); 
	}
		if (Input.GetKey (KeyCode.D) ) { 
			Transform.Rotate (0f, 5f, 0f);
		} 
		if (Input.GetKey ( KeyCode.Space ) ) { 
			Transform.position += new Vector3(0f, 1f, 0f); 
		} 
}
} 