using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsScript : MonoBehaviour
{
    public float Mass = 1;
    public float Gravity = 1;
    void Start()
    {

        Rigidbody2D sc = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        if (gameObject.tag == "Player"){
            sc.freezeRotation = true;
        }
        
        sc.gravityScale = Gravity;
        sc.mass = Mass;

        PolygonCollider2D pc2d = gameObject.AddComponent<PolygonCollider2D>() as PolygonCollider2D;
        pc2d.autoTiling = true;
    }
}
