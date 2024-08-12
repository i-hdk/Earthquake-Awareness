using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/**
 * Time interval scaling from CSV:
 * t ranges from 0 to 20 --> rescale to 5 seconds
 * shaking ranges from -1 to 1
 * adjust position from original to +- 0.2
 */

public class floor1movement : MonoBehaviour
{
    public TextAsset solution;
    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    void FixedUpdate()
    {
        string[] data = solution.text.Split(new String[] { ",", "\n" }, StringSplitOptions.None);
        double lookForTime = (Time.realtimeSinceStartupAsDouble%5)*4;
        int entries = data.Length/3;
        double desiredOffset = 0;
        for(int i = 0; i < entries; i++)
        {
            if (Double.Parse(data[3 * i]) >= lookForTime){
                desiredOffset = Double.Parse(data[3 * i + 1])*0.2;
                break;
            }
        }
        transform.position = startPosition + new Vector3((float)desiredOffset, 0, 0);
    }
}
