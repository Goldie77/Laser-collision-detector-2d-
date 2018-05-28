using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof (PlayerController))]
public class Player : MonoBehaviour {
	PlayerController controller;
	// Use this for initialization
	void Start () {
		controller = GetComponent<PlayerController> ();
	}
	

}
