using UnityEngine;

public class Cubes : MonoBehaviour {

	public GameObject [] cubes = new GameObject[83];
	public Color[] RandomColor;


	// если кубик появляються постепенно(массив не статический, а динамический), надо использовать  List


	// Use this for initialization
	void Start () {
		for(int i = 1; i < cubes.Length+1; i++)
		{
			cubes[i-1]=GameObject.Find("Cube ("+i+")");

		}

		foreach(GameObject cube in cubes){
			cube.GetComponent<MeshRenderer>().material.color = RandomColor[Random.Range(0,RandomColor.Length-1)];
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
