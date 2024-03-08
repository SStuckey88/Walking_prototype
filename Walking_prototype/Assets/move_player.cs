using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_player : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float turnSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput= Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput*6);
    }
}
