using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSat : MonoBehaviour
{
    public GameObject satellite;
    public int dir;
    public Vector3 speed;
    public Quaternion direction;
    public Quaternion up = Quaternion.Euler(0, 0, 0);
    public Quaternion left = Quaternion.Euler(0, 0, 90);
    public Quaternion down = Quaternion.Euler(0, 0, 180);
    public Quaternion right = Quaternion.Euler(0, 0, 270);
    // Use this for initialization
    void Start()
    {
        dir = 0;
        direction = right;
        speed = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {          
        satellite.transform.localRotation = direction;
        transform.Translate(speed * Time.deltaTime);
    }
}
