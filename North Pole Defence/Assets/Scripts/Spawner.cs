using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float radius = 3f;

    float x = 0f;
    float y = 0f;
    float z = 0f;

    public double timer;
    private double realTime;

    //public GameObject center;
    public GameObject projectile;
    void Start()
    {
        realTime = timer;
    }

    void Update()
    {
        realTime -= Time.deltaTime;
        if (realTime <= 0)
        {
            Vector3 center = transform.position;

            Vector3 pos = RandomCircle(center, radius);

            Quaternion rot = Quaternion.FromToRotation(Vector3.forward, center - pos);
            Instantiate(projectile, pos, rot);

            timer = timer - 0.1;
            realTime = timer;
        }


    }

    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y;
        pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        return pos;
    }


}