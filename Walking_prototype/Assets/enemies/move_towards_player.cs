using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Vector
{
    public float X { get; set; }
    public float Y { get; set; } 
    public float Z { get; set; }

    public Vector(float x, float y, float z)
    { 
    this.X = x; this.Y = y; this.Z = z;
    }

}


public class move_towards_player : MonoBehaviour
{
    GameObject player;
    Rigidbody m_Rigidbody;
    int timeLimit = 600;
    double time = 0;
    Vector3 pos;
    int i = 0;
    Vector3 check;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        m_Rigidbody = GetComponent<Rigidbody>();
        pos = player.transform.position - transform.position;
        move_towards(pos);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1.5)
        {
            pos = player.transform.position - transform.position;
            move_towards(pos);
            time = 0;
        }
        if (pos.y < 5 && pos.x < 5 && pos.z < 10)
        {
            health_tracker.invokeDamage(5);
        }

        
    }

    void move_towards(Vector3 pos)
    {
        m_Rigidbody.AddForce(pos, ForceMode.Force);
    }
}
