using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class move_camera : MonoBehaviour
{
    public int[] turns = { 90, -90, 0, 90, 0, -90, 0, 90, 90, 0, 0, 90 };
    public float turn_threshold;
    public int length;
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        turn_threshold = 0;
        length = turns.Length;
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (i == length) {

        }
        transform.Translate(Vector3.forward * Time.deltaTime);
        turn_threshold += Time.deltaTime;

        if (turn_threshold >= 120) {
            transform.Rotate(0, turns[i], 0);
            i++;
            turn_threshold = 0;
        }

    }
}
