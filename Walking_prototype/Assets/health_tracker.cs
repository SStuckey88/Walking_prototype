using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.UI;

public class health_tracker
{
    // Start is called before the first frame update
    public float currenthealth;
    public float maxHealth=100;
    public Slider mslider;


    void Start()
    {
        currenthealth = maxHealth;
        mslider.maxValue = 100.0f;
        mslider.minValue = 0.0f;
        mslider.value = 100.0f;
    }

    public void invokeDamage(int dam)
    {
        TakeDamage(dam);
    }

    void TakeDamage(int damage)
    {
        currenthealth -= damage;
        float inbetween = damage;
        mslider.value -= damage;
        for (int i = 0; i < 4; i++)
        {
            GameObject m = GameObject.Find("myLight" + i);
            updateLighting(currenthealth, m);
        }
    }

    public void updateLighting(float currenthealth, GameObject currLight)
    {
        float lightIntensity;
        float currhealth = currenthealth;
        lightIntensity = (currhealth / 100) - 0.1f;
        if (lightIntensity < 0)
        {
            lightIntensity = 0;
        }
        Light areaLight = currLight.GetComponent<Light>();
        areaLight.intensity = lightIntensity;
    }

}//End of Code
