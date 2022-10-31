using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    List<Collider> colliders = new List<Collider>();
    void OnCollisioEnter(Collision Collision)
    {
        if (Collision.gameObject.name == "Enemy")
        {
            Destroy(Collision.gameObject);
        }
        else
        {
            Destroy(gameObject, 5);
        }
    }

    /*void Awake()
    {
        Destroy(gameObject, 5);
    }*/
}
