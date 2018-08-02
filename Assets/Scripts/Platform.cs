using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Platform : MonoBehaviour {

	public int count;
	public Text t_count;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		t_count.text=count.ToString();
	}
	
	void OnTriggerEnter(Collider other)
	{
		if ( other.gameObject.CompareTag("cube"))
		{
			count++;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if ( other.gameObject.CompareTag("cube"))
		{
			count--;
		}
	}

	// void OnTriggerStay(Collider other)
	// {
	// 	if ( other.gameObject.CompareTag("cube"))
	// 	{
	// 		count++;
	// 	}
	// }
}
