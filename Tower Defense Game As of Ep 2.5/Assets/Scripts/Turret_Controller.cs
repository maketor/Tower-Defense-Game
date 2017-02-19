using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Controller : MonoBehaviour {

    public GameObject red_turret;
    public GameObject green_turret;

    public static Turret_Controller instance;

    Dictionary<Turret, GameObject> turretGOMap;


	// Use this for initialization
    void Awake () {

        turretGOMap = new Dictionary<Turret, GameObject>();
        instance = this;
    }

    public void OnTurretPlaced (Turret turret, Tile tile) {

        if(turret.type == Turret.Type.Basic) {

            GameObject turretGO = Instantiate(red_turret, new Vector3(tile.x + 0.5f, tile.y + 0.5f), Quaternion.identity);
            turretGO.GetComponent<CircleCollider2D>().radius = turret.radius + 0.5f;
            turretGOMap.Add(turret, turretGO);
        }

        if (turret.type == Turret.Type.Advanced) {

            GameObject turretGO = Instantiate(green_turret, new Vector3(tile.x + 0.5f, tile.y + 0.5f), Quaternion.identity);
            turretGO.GetComponent<CircleCollider2D>().radius = turret.radius + 0.5f;
            turretGOMap.Add(turret, turretGO);
        }
    }

    public void OnTurretSold (Tile tile) {

        if (tile.turret == null)
            return;

        Destroy(turretGOMap[tile.turret]);
        turretGOMap.Remove(tile.turret);
        tile.placeTower(null);
        
    }

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
