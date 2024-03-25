using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    Light myLight;
    float lightIntensity;
    float currhealth;
    void Start()
    {
        Light myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    public void updateLighting(float currenthealth) {
        currhealth = currenthealth;
        lightIntensity = (currhealth / 100) - 0.1f;
        if (lightIntensity < 0) { 
            lightIntensity = 0;
        }
        myLight.intensity = lightIntensity;
    }
}
