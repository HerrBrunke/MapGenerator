using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour {
	public int mapLength = 10;
	public GameObject Terrain;
	public List<GameObject> Tiles;
	private void Start()
	{
		GenerateMap();
	}

	void GenerateMap()
	{
		for (int x = 0; x < mapLength; x++)
		{
			for (int y = 0; y < mapLength; y++)
			{
				Instantiate(Tiles[Random.Range(0, 4)], new Vector3(x, y, 0), Quaternion.identity, Terrain.transform);
			}
		}
	}

	private void Update()
	{
		if (Input.GetMouseButton(0)) {
			GenerateMap();
		}
	}

}
