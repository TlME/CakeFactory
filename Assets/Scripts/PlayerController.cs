using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private CharacterController pl;
	// Use this for initialization
	void Start () {
        pl = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
        float moveHorizontal;
    }
}
