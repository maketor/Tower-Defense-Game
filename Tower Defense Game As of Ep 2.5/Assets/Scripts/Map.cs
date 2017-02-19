using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public static Map instance;


    public Sprite floor;
    public Sprite wall;


    public int width;
    public int height;

    Tile[,] tiles;

	// Use this for initialization
    void Awake () {

        instance = this;
    }

	void Start () {

        tiles = new Tile[width, height];

        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {



                if(j == 6 || j == 7 || j == 8) {

                    tiles[i, j] = new Tile(i, j, Tile.Type.Floor, floor);
                    tiles[i, j].RegisterOnTurretPlaced(Turret_Controller.instance.OnTurretPlaced);
                    tiles[i, j].RegisterOnTurretSold(Turret_Controller.instance.OnTurretSold);
                    continue;
                }


                if (i == 0 || j == 0 || i == width - 1 || j == height - 1) {

                    tiles[i, j] = new Tile(i, j, Tile.Type.Wall, wall);
                }
                else
                    tiles[i, j] = new Tile(i, j, Tile.Type.Floor, floor);

                tiles[i, j].RegisterOnTurretPlaced(Turret_Controller.instance.OnTurretPlaced);
                tiles[i, j].RegisterOnTurretSold(Turret_Controller.instance.OnTurretSold);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {

	}

    public Tile getTileAt (float x, float y) {

        int X = Mathf.FloorToInt(x);
        int Y = Mathf.FloorToInt(y);

        if (X < 0 || X > width - 1 || Y < 0 || Y > height - 1)
            return null;

        return tiles[X, Y];

    }
}
