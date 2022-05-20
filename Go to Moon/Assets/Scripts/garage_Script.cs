using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garage_Script : MonoBehaviour
{
    [Header("Specs")]
    public int speed;
    public int durability;
    public int duration;

    [Header("Upgrades")]
    public int rigidity;
    public int engine;
    public int wing;
    public int accelerate;
    public int fuel;

    [Header("RocketParts")]
    public Sprite[] Wings;
    public Sprite[] Boosters;
    public Sprite[] Engines;
    public Sprite[] FuelTank;
    public Sprite[] Body;
    public Sprite[] Heads;



    void Start()
    {
        
    }    
    void Update()
    {
        SpecCheck();
    }
    void SpecCheck()
    {

        speed = (wing / 2) + (engine);
        durability = (rigidity) + (wing);
        duration = (rigidity / 2) + (fuel);
    }
    void RocketPartCheck()
    {

    }
    public void RigidityUpgrade()
    {

        rigidity++;

    }
    public void EngineUpgrade()
    {

        engine++;

    }
    public void WingUpgrade()
    {

        wing++;

    }
    public void AccelerateUpgrade()
    {

        accelerate++;

    }
    public void FuelUpgrade()
    {

        fuel++;

    }
}
