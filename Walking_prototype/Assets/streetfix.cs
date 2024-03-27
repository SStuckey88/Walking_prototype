using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class streetfix : MonoBehaviour
{
    float time = 0;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 50)
        {
            transform.position = new Vector3(569.3234f, -318.3219f, -1141.257f);
            time = 0;
        }
    }
}
