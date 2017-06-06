using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour {

    public GameObject keyFabWhite;
    public GameObject keyFabBlack;
    public float keySize;

    public List<GameObject> keys;

    private static int[] whiteBlack = { 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0 };

    // Use this for initialization
    void Start () {
        keys = new List<GameObject>();
	    // make 81 keys
        for (int i = 0; i < 81; i++) {
            int whiteOrBlack = whiteBlack[i % 12];
            GameObject newKey;
            if (whiteOrBlack == 0) {
                newKey = GameObject.Instantiate(keyFabWhite, this.transform);
            }
            else {
                newKey = GameObject.Instantiate(keyFabBlack, this.transform);
            }
            var basePosn = this.transform.position;
            var newPosn = basePosn;
            newPosn.z = i * keySize;
            newKey.transform.position = newPosn;
            newKey.GetComponent<HingeJoint>().connectedAnchor = newPosn;
            keys.Add(newKey);
        }	
	}
	
	// Update is called once per frame
	void Update () {
        var pressed = Quaternion.AngleAxis(30, Vector3.forward);
        var unpressed = Quaternion.identity;
	    if (Input.GetKey(KeyCode.A)) {
            keys[0].transform.localRotation = pressed;
        }
        else {
            keys[0].transform.localRotation = unpressed;
        }

        if (Input.GetKey(KeyCode.S)) {
            keys[1].transform.localRotation = pressed;
        }
        else {
            keys[1].transform.localRotation = unpressed;
        }

        if (Input.GetKey(KeyCode.D)) {
            keys[2].transform.localRotation = pressed;
        }
        else {
            keys[2].transform.localRotation = unpressed;
        }

        if (Input.GetKey(KeyCode.F)) {
            keys[3].transform.localRotation = pressed;
        }
        else {
            keys[3].transform.localRotation = unpressed;
        }

        if (Input.GetKey(KeyCode.G)) {
            keys[4].transform.localRotation = pressed;
        }
        else {
            keys[4].transform.localRotation = unpressed;
        }
    }
}
