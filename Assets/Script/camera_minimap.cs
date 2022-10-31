using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_minimap : MonoBehaviour
{
    public GameObject player; //o player será arrasta pra cá
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
