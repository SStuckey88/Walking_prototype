using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

{
    Color[] color_wheel = { Color.black, Color.blue, Color.red, Color.cyan, Color.clear, Color.green, Color.magenta, Color.white, Color.yellow, Color.grey };
    Renderer m_Renderer;
    GameObject parentCube;
    Rigidbody m_Rigidbody;
    public int threshold = 0;
    bool hasJumped = false;
    // Start is called before the first frame .update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        m_Rigidbody = GetComponent<Rigidbody>();
        parentCube = transform.parent.gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        
        
            if (Input.GetKeyDown(" ")) {
            if (!hasJumped) {
                    m_Rigidbody.AddForce(new Vector3(0f, 420f, 0f), ForceMode.Force);
                    hasJumped = true;
                }
            
            else {
                hasJumped = false;
            }
        }
        }
}

