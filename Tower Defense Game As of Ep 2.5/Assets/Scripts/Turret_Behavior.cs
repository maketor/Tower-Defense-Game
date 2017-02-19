using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Behavior : MonoBehaviour {

    GameObject turretHead;

	// Use this for initialization
    void Awake () {

        turretHead = transform.GetChild(0).gameObject;
    }

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D (Collider2D coll) {

        if(coll != null) {


            //Coordinates of gameObject that we want to look at

            turretHead.transform.eulerAngles = new Vector3 (
                0f,
                0f,
                Mathf.Atan2(transform.position.y - coll.gameObject.transform.position.y, transform.position.x - coll.gameObject.transform.position.x) * Mathf.Rad2Deg
            );
        }
    }

}
