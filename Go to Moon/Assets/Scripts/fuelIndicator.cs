using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelIndicator : MonoBehaviour
{
    public shipController ShipController;
    public GameObject needle;
    public float vehicleSpeed;

    public  float startPosition=180, endPosition=0;
    public float desiredPosition;
    private float indicatorSpeed;
    public float temp;




    void Start()
    {
       
    }

    void FixedUpdate()
    {
        vehicleSpeed = ShipController.fuel;
        updateNeedle();
    }

    public void updateNeedle()
    {
        desiredPosition = startPosition - endPosition;
        temp = vehicleSpeed / 180;
        needle.transform.eulerAngles = new Vector3(0, 0, (startPosition - temp * desiredPosition));
        if (needle.transform.eulerAngles.z>=180)
        {
            Debug.Log("yakıt bitti");
        }
        
    }
}
