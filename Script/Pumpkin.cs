using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour {
    public float moveforce = 10f;
    private Rigidbody mybody;
    void Awake()
    {
        mybody = GetComponent<Rigidbody>();

    }
	// Use this for initialization
	void Start () {
		
	} 
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -10)
        {
            Time.timeScale = 0f;
        }
	}
    void FixedUpdate()
    {
        movepumpkin();
    }
    void movepumpkin()
    {
        float h = Input.GetAxis("Horizontal");
        float v= Input.GetAxis("Vertical");
        mybody.AddForce(new Vector3(h*moveforce,0f,v*moveforce));

    }
    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Golem" || target.tag == "Gates")
        {
            Time.timeScale = 0f;
        }
    }
}
