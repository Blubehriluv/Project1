using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform tf;
    public float speed;

	// Use this for initialization
	void Start ()
	{
	    tf = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
    
        tf.position = tf.position + (Vector3.up * speed);
    }
}
