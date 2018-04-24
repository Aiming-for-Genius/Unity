using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidscript : MonoBehaviour {
	float dgr = 0;
	int power = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 v = transform.position;
		//スペースバーを押した時の処理
		if(Input.GetKeyDown(KeyCode.Space)){
			power = 0;
		}
		//スペースバーを押している時の処理
		if(Input.GetKey(KeyCode.Space)){
			power++;
		}
		//スペースバーを離した時の処理
		if(Input.GetKeyUp(KeyCode.Space)){
			Vector3 pos = Camera.main.transform.position;
			v -= pos;
			v *= power;
			v.y = 0;
			transform.GetComponent<Rigidbody> ().AddForce (v);
		}
		//左矢印キーの処理、視点を回す
		if(Input.GetKey(KeyCode.LeftArrow)){
			Camera.main.transform.RotateAround (v, new Vector3 (0, 10, 0), -0.1f);
			dgr += 0.1f;
		}
		//右矢印キーの処理、視点を回す
		if(Input.GetKey(KeyCode.RightArrow)){
			Camera.main.transform.RotateAround (v, new Vector3 (0, 10, 0), 0.1f);
			dgr -= 0.1f;
		}
		//カメラの新たな位置の計算と設定
		float d = (2 * Mathf.PI) * (dgr / 360);
		float x = Mathf.Sin (d);
		float y = Mathf.Cos (d);
		x *= 10f;
		y *= 10f;
		v.x += x;
		v.y += 10f;
		v.z -= y;
		Camera.main.transform.position = v;
	}
}
