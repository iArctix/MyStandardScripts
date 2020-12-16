using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnrandom : MonoBehaviour {
    public List<Vector3> spawnPoints = new List<Vector3>();

	// Use this for initialization
	void Start () {

        Spawn();
	}
	
	// Update is called once per frame
	public void Spawn()
    {
        transform.position = spawnPoints[Random.Range(0, spawnPoints.Count + 1)];	
	}
}
