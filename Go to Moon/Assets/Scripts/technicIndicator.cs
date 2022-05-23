using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class technicIndicator : MonoBehaviour
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
        vehicleSpeed = ShipController.deadCount;
        updateNeedle();

    }

    public void updateNeedle()
    {
        desiredPosition = startPosition - endPosition;
        float temp = vehicleSpeed / 3;
        needle.transform.eulerAngles = new Vector3(0, 0, (startPosition - temp * desiredPosition));
        if (needle.transform.eulerAngles.z<=0)
        {
            Debug.Log("ship patladı teknik");
        }
    }
}
