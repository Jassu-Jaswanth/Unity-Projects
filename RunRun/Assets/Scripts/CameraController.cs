using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Player player;
    private float distance;
    private Vector3 lastlocation;
    void Start()
    {
        player = FindObjectOfType<Player>();
        lastlocation = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance = player.transform.position.x - lastlocation.x;

        transform.position = new Vector3(
            transform.position.x + distance,
            transform.position.y,
            transform.position.z
        );
        lastlocation = player.transform.position;
    }
}
