using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour {

    Camera camera;

	// Use this for initialization
    void Awake () {

        camera = GetComponent<Camera>();
    }

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        camera.orthographicSize = (Screen.height) / 16f * 0.5f;
	}
}
