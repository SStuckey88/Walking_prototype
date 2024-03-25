using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    
    

    // Update is called once per frame
    public void updateLighting(float currenthealth, GameObject currLight) {
        float lightIntensity;
        float currhealth = currenthealth;
        lightIntensity = (currhealth / 100) - 0.1f;
        if (lightIntensity < 0) { 
            lightIntensity = 0;
        }
        Light areaLight = currLight.GetComponent<Light>();
        areaLight.intensity = lightIntensity;
    }
}
