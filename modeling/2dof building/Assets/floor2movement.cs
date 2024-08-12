using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor2movement : MonoBehaviour
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
        double lookForTime = (Time.realtimeSinceStartupAsDouble % 5) * 4;
        int entries = data.Length / 3;
        double desiredOffset = 0;
        for (int i = 0; i < entries; i++)
        {
            if (Double.Parse(data[3 * i]) >= lookForTime)
            {
                desiredOffset = Double.Parse(data[3 * i + 2]) * 0.2;
                break;
            }
        }
        transform.position = startPosition + new Vector3((float)desiredOffset, 0, 0);
    }
}
