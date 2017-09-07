using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    private Transform pumpkinpos;
    private float zDistance = 10f;
    private float yDistance = 4f;
    // Use this for initialization
    void Awake () {
        pumpkinpos = GameObject.Find("pumpkin").transform;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 temp = transform.position;
        temp.y = pumpkinpos.position.y + yDistance;
        temp.z = pumpkinpos.position.z - zDistance;
        transform.position = temp;
    }
    
}
