using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    GameObject player;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        pos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pos.z = player.transform.position.z - 3;
        pos.x = player.transform.position.x;
        pos.y = player.transform.position.y + 2;
        gameObject.transform.position = pos;
    }
}
