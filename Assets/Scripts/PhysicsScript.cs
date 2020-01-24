using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsScript : MonoBehaviour
{
    
    void Start()
    {
         Rigidbody2D sc = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        sc.freezeRotation = true;
        PolygonCollider2D pc2d = gameObject.AddComponent<PolygonCollider2D>() as PolygonCollider2D;
        pc2d.autoTiling = true;
    }
}
