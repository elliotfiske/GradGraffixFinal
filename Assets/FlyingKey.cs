using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingKey : MonoBehaviour {

    public GameObject particles;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector3(0.03f, 0));
	}

    private void OnTriggerEnter(Collider other) {
        GameObject.Instantiate(particles, this.transform.position, Quaternion.identity, this.transform.parent);
        GameObject.Destroy(this.gameObject);
    }
}
