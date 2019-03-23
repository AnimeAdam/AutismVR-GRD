using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAI : MonoBehaviour
{
    private float movement;

    public Vector3 spawnPoint = new Vector3(-237.2f, 1.46f, 11.5f);
    public Vector3 deadZone = new Vector3(-237.2f, 1.46f, 11.5f);
    public Vector3 direction = Vector3.forward;
    public bool facing = false;
    public float speed = 1f;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement = (direction.x*speed)*Time.deltaTime;
        transform.position += new Vector3(movement, 0f,0f);

        if (!facing && transform.position.x > deadZone.x)
        {
            transform.position = spawnPoint;
        }
        if (facing && transform.position.x < deadZone.x)
        {
            transform.position = spawnPoint;
        }
    }
}
