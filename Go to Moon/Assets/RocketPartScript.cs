using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketPartScript : MonoBehaviour
{
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

    // Update is called once per frame
    void Update()
    {
        RocketPartCheck();
    }
    void RocketPartCheck()
    {
        //if (wing % 3 == 0)
        // {
        WingsPart.GetComponent<SpriteRenderer>().sprite = Wings[Mathf.FloorToInt(PlayerPrefs.GetInt("wing") / 3)];
        // }
        //  if (rigidity % 3 == 0)
        // {
        BodyPart.GetComponent<SpriteRenderer>().sprite = Body[Mathf.FloorToInt(PlayerPrefs.GetInt("rigidity") / 3)];
        HeadsPart.GetComponent<SpriteRenderer>().sprite = Heads[Mathf.FloorToInt(PlayerPrefs.GetInt("rigidity") / 3)];
        //}
        // if (accelerate % 3 == 0)
        // {
        BoostersPart.GetComponent<SpriteRenderer>().sprite = Boosters[(PlayerPrefs.GetInt("accelerate") / 3)];
        // }
        //if (fuel % 3 == 0)
        //  {
        FuelTankPart.GetComponent<SpriteRenderer>().sprite = FuelTank[(PlayerPrefs.GetInt("fuel") / 3)];
        //  }
        // if (engine % 3 == 0)
        //  {
        EnginesPart.GetComponent<SpriteRenderer>().sprite = Engines[(PlayerPrefs.GetInt("engine") / 3)];
        //  }
    }
}
