using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squarescript : MonoBehaviour
{
    Color[] color_wheel = { Color.black, Color.blue, Color.red, Color.cyan, Color.clear, Color.green, Color.magenta, Color.white, Color.yellow, Color.grey };
    Renderer m_Renderer;
    public int shiftCount = 0;
    // Start is called before the first frame .update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            Color randColor = color_wheel[Random.Range(0, 9)];
            Debug.Log("The color is: "+ randColor);
            m_Renderer.material.color = randColor;
            shiftCount++;
        }
    }
    
    public Color ReturnColor()
    {
        return m_Renderer.material.color;
    }

}

