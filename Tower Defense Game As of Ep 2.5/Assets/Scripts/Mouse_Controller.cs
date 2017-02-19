using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Controller : MonoBehaviour {

    Tile tileUnderMouse;
    Vector2 mousePos;

	// Use this for initialization
    void Awake () {

        mousePos = Vector2.zero;
        tileUnderMouse = null;
    }


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        tileUnderMouse = Map.instance.getTileAt(mousePos.x, mousePos.y);

        if(tileUnderMouse != null) {

            if(Input.GetMouseButtonDown(0)) {

                tileUnderMouse.placeTower(Turret.Red_Turret());
            }
            if (Input.GetMouseButtonDown(1)) {

                tileUnderMouse.placeTower(Turret.Green_Turret());
            }
        }

	}
}
