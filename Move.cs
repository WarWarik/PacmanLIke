using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour{
	public GameObject obj;
	public float moveSpeed = 30f;

    void Update(){
    	if(Input.GetKey(KeyCode.UpArrow))
			obj.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.DownArrow))
			obj.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.LeftArrow))
			obj.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.RightArrow))
			obj.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
	}   
}
