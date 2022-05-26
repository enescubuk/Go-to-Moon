using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hotIndicator : MonoBehaviour
{
    public shipController ShipController;
    public GameObject needle;
    public float vehicleSpeed;

    private  float startPosition=180, endPosition=0;
    private float desiredPosition;
    private float indicatorSpeed;




    void Start()
    {
       
    }

    void FixedUpdate()
    {
        vehicleSpeed = ShipController.shipHot;
        updateNeedle();
    }

    public void updateNeedle()
    {
        desiredPosition = startPosition - endPosition;
        float temp = vehicleSpeed / 100;
        needle.transform.eulerAngles = new Vector3(0, 0, (startPosition - temp * desiredPosition));
    }
}
