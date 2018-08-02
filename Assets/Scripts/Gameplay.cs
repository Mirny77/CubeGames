using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour {

	// Use this for initialization
	public int force;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				// if ( hit.collider.gameObject.name == "cube") - если искать по имени
				if ( hit.collider.gameObject.CompareTag("cube")){

					hit.collider.GetComponent<Rigidbody>().AddForce(Vector3.up*force);
				}

			}
			
	
			
		}


		
	}
}
