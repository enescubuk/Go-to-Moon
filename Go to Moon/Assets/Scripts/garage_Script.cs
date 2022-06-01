using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class garage_Script : MonoBehaviour
{
    [Header("Coins")]
    public int coin;
    [SerializeField] int coinDecrease10;
    [SerializeField] int coinDecrease20;

    [SerializeField] int maxValue;
    [Header("Specs")]
    public float speed;
    public float durability;
    public float duration;

    [Header("Upgrades")]
    public int rigidity;
    public int engine;
    public int wing;
    public int accelerate;
    public int fuel;

   /* [Header("RocketParts")]
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
    public GameObject HeadsPart;*/

    [Header("Coins")]
    [SerializeField] TextMeshProUGUI RigidityText;
    [SerializeField] TextMeshProUGUI EngineText;
    [SerializeField] TextMeshProUGUI WingText;
    [SerializeField] TextMeshProUGUI AccelerateText;
    [SerializeField] TextMeshProUGUI FuelText;
    [SerializeField] TextMeshProUGUI SpeedText;
    [SerializeField] TextMeshProUGUI DurabilityText;
    [SerializeField] TextMeshProUGUI DurationText;
    [SerializeField] TextMeshProUGUI CoinText;


    private void Awake()
    {
        speed = PlayerPrefs.GetFloat("speed");
        durability = PlayerPrefs.GetFloat("durabilty");
        duration = PlayerPrefs.GetFloat("duration");


        rigidity = PlayerPrefs.GetInt("rigidity");
        engine = PlayerPrefs.GetInt("engine");
        wing = PlayerPrefs.GetInt("wing");
        accelerate = PlayerPrefs.GetInt("accelerate");
        fuel = PlayerPrefs.GetInt("fuel");


    }
    void Start()
    {
        
    }    
    void Update()
    {
        TextFunc();
        SpecCheck();
        //
        //RocketPartCheck();
        PlayerPrefsFunc();
    }

    void TextFunc()
    {


        RigidityText.text = "Lvl: " + (rigidity);
        EngineText.text = "Lvl: " + (engine);
        WingText.text = "Lvl: " + (wing);
        AccelerateText.text = "Lvl: " + (accelerate);
        FuelText.text = "Lvl: " + (fuel);

        SpeedText.text = "Speed Lvl: \n" + (speed);
        DurabilityText.text = "Durability Lvl: \n" + (durability);
        DurationText.text = "Duration Lvl: \n" + (duration);

        CoinText.text =  ""+ (coin) + " :Gold";
    }

    void PlayerPrefsFunc()
    {

        PlayerPrefs.SetFloat("speed",speed);
        PlayerPrefs.SetFloat("durability", durability);
        PlayerPrefs.SetFloat("duration", duration);


        //

        PlayerPrefs.SetInt("rigidity", rigidity);
        PlayerPrefs.SetInt("engine", engine);
        PlayerPrefs.SetInt("wing", wing);
        PlayerPrefs.SetInt("accelerate", accelerate);
        PlayerPrefs.SetInt("fuel", fuel);
        


    }
    void SpecCheck()
    {

        speed = (wing / 2) + (engine);
        durability = (rigidity) + (wing);
        duration = (rigidity / 2) + (fuel);
    }
   /* void RocketPartCheck()
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
    }*/
    public void RigidityUpgrade()
    {
        if (rigidity < maxValue)
        {
            coin -= coinDecrease10;
            coinDecrease10 *= 2;
            rigidity++;
        }
        

    }
    public void EngineUpgrade()
    {
        if (engine < maxValue)
        {
            coin -= coinDecrease20;
            coinDecrease10 *= 2;
            engine++;
        }
        

    }
    public void WingUpgrade()
    {
        if (wing < maxValue)
        {
            coin -= coinDecrease10;
            coinDecrease10 *= 2;
            wing++;
        }
        

    }
    public void AccelerateUpgrade()
    {
        if (accelerate < maxValue)
        {
            coin -= coinDecrease10;
            coinDecrease10 *= 2;
            accelerate++;
        }
        

    }
    public void FuelUpgrade()
    {
        if (fuel < maxValue)
        {
            coin -= coinDecrease20;
            coinDecrease10 *= 2;
            fuel++;
        }
    }
}
