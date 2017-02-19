using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret {
    
    public enum Type { Basic, Advanced }
    public Type type { get; private set; }

    public int fireRate { get; private set; }
    public float radius { get; private set; }
    public int damage { get; private set; }

    private Turret () {

    }

    public Turret (Turret prototype) {

        type = prototype.type;
        fireRate = prototype.fireRate;
        damage = prototype.damage;
        radius = prototype.radius;
    }

    public static Turret Red_Turret() {

        Turret prototype = new Turret();
        prototype.type = Type.Basic;
        prototype.radius = 3.0f;

        //Assign all data values


        return prototype;
    }

    public static Turret Green_Turret () {

        Turret prototype = new Turret();
        prototype.type = Type.Advanced;
        prototype.radius = 2.0f;


        //Assign all data values


        return prototype;
    }
}
