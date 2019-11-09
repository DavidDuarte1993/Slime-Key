﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMeter : MonoBehaviour
{
    float rm;
    GameObject needle;
    void Start()
    {
        needle=transform.Find("needle").gameObject;
    }


    void Update()
    {
        rm=PlayerPrefs.GetInt("RockMeter");

        needle.transform.localPosition = new Vector3((rm - 25) / 16.666f, 0, 0);
    }
}
