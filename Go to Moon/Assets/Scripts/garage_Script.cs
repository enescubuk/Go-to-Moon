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

    [Header("RocketParts")]
    public Sprite WingsPart;
    public Sprite BoostersPart;
    public Sprite EnginesPart;
    public Sprite FuelTankPart;
    public Sprite BodyPart;
    public Sprite HeadsPart;



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
        if (wing % 3 == 0)
        {
           WingsPart = Wings[(wing / 3)];
        }
        if (rigidity % 3 == 0)
        {
            BodyPart = Body[(rigidity / 3)];
            HeadsPart = Heads[(rigidity / 2)];
        }
        if (accelerate % 3 == 0)
        {
            BoostersPart = Boosters[(accelerate / 3)];
        }
        if (fuel % 3 == 0)
        {
            FuelTankPart = FuelTank[(fuel / 3)];
        }
        if (engine % 3 == 0)
        {
            EnginesPart = Engines[(engine / 3)];
        }
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
