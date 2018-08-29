using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController2 : MonoBehaviour {

    public GameObject player; //pulling transform data from player
    private Vector3 offset; //calculating the difference

	// Use this for initialization
	void Start () 
    {
        offset = transform.position - player.transform.position; //cameras position minus player's position
	}
	
	// Update is called once per frame
	void LateUpdate () //runs every frame, but runs at the end of update
    { 
        transform.position = player.transform.position + offset; //cameras new transform is equal to player's current + offset
	}
}
