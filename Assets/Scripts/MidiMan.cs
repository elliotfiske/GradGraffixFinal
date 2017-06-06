using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidiMan : MonoBehaviour {

    public GameObject keyfella;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        for (int note = 0; note < 100; note++) {
            var result = MidiJack.MidiMaster.GetKeyDown(note);
            if (result) {
                print("WE DID IT WITH " + note);
                keyfella.transform.Translate(0, 0, -1);
            }
        }
    }
}
