using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garage_Script : MonoBehaviour
{
    [SerializeField] int maxValue;
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
    public GameObject WingsPart;
    public GameObject BoostersPart;
    public GameObject EnginesPart;
    public GameObject FuelTankPart;
    public GameObject BodyPart;
    public GameObject HeadsPart;



    void Start()
    {
        
    }    
    void Update()
    {
        SpecCheck();
        //
        RocketPartCheck();
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
           WingsPart.GetComponent<SpriteRenderer>().sprite = Wings[(wing / 3)];
        }
        if (rigidity % 3 == 0)
        {
            BodyPart.GetComponent<SpriteRenderer>().sprite = Body[(rigidity / 3)];
            HeadsPart.GetComponent<SpriteRenderer>().sprite = Heads[(rigidity / 3)];
        }
        if (accelerate % 3 == 0)
        {
            BoostersPart.GetComponent<SpriteRenderer>().sprite = Boosters[(accelerate / 3)];
        }
        if (fuel % 3 == 0)
        {
            FuelTankPart.GetComponent<SpriteRenderer>().sprite = FuelTank[(fuel / 3)];
        }
        if (engine % 3 == 0)
        {
            EnginesPart.GetComponent<SpriteRenderer>().sprite = Engines[(engine / 3)];
        }
    }
    public void RigidityUpgrade()
    {
        if (rigidity < maxValue)
        {
            rigidity++;
        }
        

    }
    public void EngineUpgrade()
    {
        if (engine < maxValue)
        {
            engine++;
        }
        

    }
    public void WingUpgrade()
    {
        if (wing < maxValue)
        {
            wing++;
        }
        

    }
    public void AccelerateUpgrade()
    {
        if (accelerate < maxValue)
        {
            accelerate++;
        }
        

    }
    public void FuelUpgrade()
    {
        if (fuel < maxValue)
        {
            fuel++;
        }
        

    }
}
