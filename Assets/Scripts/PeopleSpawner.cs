using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleSpawner : MonoBehaviour {
	public int length = 10;
	public Sprite[] spriteContainer;
	public int rndNumber;
	public bool isSpawned = false;

	private void Awake()
	{
		isSpawned = false;
		rndNumber = Random.Range(1, 5);
	}
	// Use this for initialization
	void Start () {
		
		GenerateMessage(spriteContainer[0]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GenerateMessage(Sprite sprite) {
		for (int z = 0; z < length; z++)
		{
			for (int x = 0; x < length; x++)
			{
				Debug.Log(rndNumber);
				//
				if (!isSpawned && z % (x+1) == rndNumber) {
					Debug.Log("Alarm!");
					Debug.Log(rndNumber);

				}
				//
				GameObject obj = new GameObject("boy");
				SpriteRenderer renderer = obj.AddComponent<SpriteRenderer>();
				renderer.sprite = sprite;
				int posX = (x + 1) * x -10;
				int posZ = (z + 1) * x + 10;
				obj.transform.position = new Vector3(posX, posZ, -5);
				Debug.LogFormat("x: " + x + " z: " + z);
			}
		}
	}
	////start
	//global bool isSpawned = false;
	//int rndNumber = Random.Range(0, 10);
	////inMapGenerator
	//void SpwanRandom(Vector2Int dimension) {

	//	if (!isSpawned && y % x == rndNumber) {
	//		isSpawned = true;
	//		Instantiate<Player>(Player(dimension));
	//	}
	//}
}
