﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamondSpin : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 1.5f, 0f));
    }
}
