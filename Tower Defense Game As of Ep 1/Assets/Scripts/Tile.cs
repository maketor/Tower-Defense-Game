using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {
    
    public enum Type { Floor, Wall }
    Type type;


    public Tile (int x, int y, Type type, Sprite sp) {

        this.type = type;

        GameObject tileGO = new GameObject("Tile_" + x + "_" + y);
        tileGO.transform.position = new Vector3(x, y);
        tileGO.transform.SetParent(Map.instance.transform, true);

        SpriteRenderer render = tileGO.AddComponent<SpriteRenderer>();
        render.sprite = sp;

    }
    
}
