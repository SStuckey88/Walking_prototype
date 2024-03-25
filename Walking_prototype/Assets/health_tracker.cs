using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health_tracker : MonoBehaviour
{
    // Start is called before the first frame update
    public float currenthealth;
    public float maxHealth=100;

    public Slider mslider;


    void Start()
    {
        currenthealth=maxHealth;
        mslider.maxValue = 100.0f;
        mslider.minValue = 0.0f;
        mslider.value = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
        
    }

    void TakeDamage(int damage)
    {
        currenthealth -= damage;
        mslider.value -= 10.0f;
        Lights.updateLighting(currenthealth);
    }

}//End of Code
