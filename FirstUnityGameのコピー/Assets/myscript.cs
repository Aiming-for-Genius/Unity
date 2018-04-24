using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (1f, 1f, 1f);
		Animator animator = GetComponent<Animator> ();
		int flag = animator.GetInteger ("flag");

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			flag++;
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			flag--;
		}
		animator.SetInteger ("flag", flag);
	}
}