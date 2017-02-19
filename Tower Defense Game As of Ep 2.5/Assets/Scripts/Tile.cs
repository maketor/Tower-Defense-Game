using System.Collections;
using System.Collections.Generic;

using System;
using UnityEngine;

public class Tile {

    Action<Turret, Tile> OnTurretPlacedCallback;
    Action<Tile> OnTurretSoldCallback;

    public enum Type { Floor, Wall }

    public Turret turret { get; private set; }
    public Type type { get; private set; }
    public int x { get; private set; }
    public int y { get; private set; }



    public Tile (int x, int y, Type type, Sprite sp) {

        this.type = type;
        turret = null;

        this.x = x;
        this.y = y;

        GameObject tileGO = new GameObject("Tile_" + x + "_" + y);
        tileGO.transform.position = new Vector3(x, y);
        tileGO.transform.SetParent(Map.instance.transform, true);

        SpriteRenderer render = tileGO.AddComponent<SpriteRenderer>();
        render.sprite = sp;

    }


    public void placeTower (Turret prototype) {

        if (type != Type.Floor)
            return;

        if (turret != null)
            return;

        turret = new Turret(prototype);
        OnTurretPlacedCallback(turret, this);

    }

    public void sellTower () {

        if (turret == null)
            return;

        OnTurretSoldCallback(this);
        turret = null;
    }

    public void RegisterOnTurretPlaced (Action<Turret, Tile> callback) {

        OnTurretPlacedCallback += callback;
    }

    public void RegisterOnTurretSold (Action<Tile> callback) {

        OnTurretSoldCallback += callback;
    }

}
