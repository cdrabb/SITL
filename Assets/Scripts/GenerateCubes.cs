using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCubes : MonoBehaviour {

	public GameObject[, ,] cubeGrid = new GameObject[10,1,10];
	public Transform[] blocks;
	public int min;
	public int max;
	public int xMax;
	public int yMax;
	public int zMax;

	
	// Use this for initialization
	void Start () {
		for(int x = 0; x < cubeGrid.GetLength(2); x++)
		{
			for (int y = 0; y < cubeGrid.GetLength(1); y++)
			{
				for (int z = 0; z < cubeGrid.GetLength(0); z++)
				{
					int index = Random.Range(min, max);

					if (blocks[index].tag == "plane")
					{
						Debug.Log("plane");
						Instantiate(blocks[index], new Vector3(x, y + .4f, z), Quaternion.identity);
					}
					else if(blocks[index].tag == "plane_cube")
					{
						Debug.Log("plane_cube");
						Instantiate(blocks[index], new Vector3(x, y - .6f, z), Quaternion.identity);
					}
					else
					{
						Debug.Log("cube");
						Instantiate(blocks[index], new Vector3(x, y, z), Quaternion.identity);
					}
					//GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
					//cube.transform.position = new Vector3(i, j, k);
					//cube.GetComponent<Renderer>().material.mainTexture = texture;
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
