using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class garage_Script : MonoBehaviour
{
    [Header("Coins")]
    
    public int shipLevel;

    [Header("Coins")]
    public int coin;
    [SerializeField] int coinDecreaseWing;
    [SerializeField] int coinDecreaseEngine;
    [SerializeField] int coinDecreaseRigidity;
    [SerializeField] int coinDecreaseFuel;
    [SerializeField] int coinDecreaseAcclerate;
    

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

    
    private void Start()
    {
        shipLevel = PlayerPrefs.GetInt("currentShip");

        switch (shipLevel)
        {
            case 0:
                Debug.Log(1);
                speed = PlayerPrefs.GetFloat("speed");
                durability = PlayerPrefs.GetFloat("durabilty");
                duration = PlayerPrefs.GetFloat("duration");


                rigidity = PlayerPrefs.GetInt("rigidity");
                engine = PlayerPrefs.GetInt("engine");
                wing = PlayerPrefs.GetInt("wing");
                accelerate = PlayerPrefs.GetInt("accelerate");
                fuel = PlayerPrefs.GetInt("fuel");

                break;
            case 1:
                Debug.Log(2);
                speed = PlayerPrefs.GetFloat("speed2");
                durability = PlayerPrefs.GetFloat("durabilty2");
                duration = PlayerPrefs.GetFloat("duration2");


                rigidity = PlayerPrefs.GetInt("rigidity2");
                engine = PlayerPrefs.GetInt("engine2");
                wing = PlayerPrefs.GetInt("wing2");
                accelerate = PlayerPrefs.GetInt("accelerate2");
                fuel = PlayerPrefs.GetInt("fuel2");

                break;
            case 2:
                Debug.Log(3);
                speed = PlayerPrefs.GetFloat("speed3");
                durability = PlayerPrefs.GetFloat("durabilty3");
                duration = PlayerPrefs.GetFloat("duration3");


                rigidity = PlayerPrefs.GetInt("rigidity3");
                engine = PlayerPrefs.GetInt("engine3");
                wing = PlayerPrefs.GetInt("wing3");
                accelerate = PlayerPrefs.GetInt("accelerate3");
                fuel = PlayerPrefs.GetInt("fuel3");

                break;
            case 3:
                Debug.Log(4);
                speed = PlayerPrefs.GetFloat("speed4");
                durability = PlayerPrefs.GetFloat("durabilty4");
                duration = PlayerPrefs.GetFloat("duration4");


                rigidity = PlayerPrefs.GetInt("rigidity4");
                engine = PlayerPrefs.GetInt("engine4");
                wing = PlayerPrefs.GetInt("wing4");
                accelerate = PlayerPrefs.GetInt("accelerate4");
                fuel = PlayerPrefs.GetInt("fuel4");

                break;
            default:
        break;
        }
        
        CoinPrefsFunc();
    }
    void Update()
    {

        shipLevel = PlayerPrefs.GetInt("currentShip");
        TextFunc();
        SpecCheck();
       
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
        PlayerPrefs.SetInt("Coin", coin);
        switch (shipLevel)
        {
            case 0:
                PlayerPrefs.SetFloat("speed", speed);
                PlayerPrefs.SetFloat("durability", durability);
                PlayerPrefs.SetFloat("duration", duration);


                //

                PlayerPrefs.SetInt("rigidity", rigidity);
                PlayerPrefs.SetInt("engine", engine);
                PlayerPrefs.SetInt("wing", wing);
                PlayerPrefs.SetInt("accelerate", accelerate);
                PlayerPrefs.SetInt("fuel", fuel);

                //
                PlayerPrefs.SetInt("coinDecreaseRigiditiy", coinDecreaseRigidity);
                PlayerPrefs.SetInt("coinDecreaseEngine", coinDecreaseEngine);
                PlayerPrefs.SetInt("coinDecreaseWing", coinDecreaseWing);
                PlayerPrefs.SetInt("coinDecreaseAccelerate", coinDecreaseAcclerate);
                PlayerPrefs.SetInt("coinDecreaseFuel", coinDecreaseFuel);
                //
                
                break;
            case 1:
                PlayerPrefs.SetFloat("speed1", speed);
                PlayerPrefs.SetFloat("durability1", durability);
                PlayerPrefs.SetFloat("duration1", duration);


                //

                PlayerPrefs.SetInt("rigidity2", rigidity);
                PlayerPrefs.SetInt("engine2", engine);
                PlayerPrefs.SetInt("wing2", wing);
                PlayerPrefs.SetInt("accelerate2", accelerate);
                PlayerPrefs.SetInt("fuel2", fuel);

                //
                PlayerPrefs.SetInt("coinDecreaseRigiditiy2", coinDecreaseRigidity);
                PlayerPrefs.SetInt("coinDecreaseEngine2", coinDecreaseEngine);
                PlayerPrefs.SetInt("coinDecreaseWing2", coinDecreaseWing);
                PlayerPrefs.SetInt("coinDecreaseAccelerate2", coinDecreaseAcclerate);
                PlayerPrefs.SetInt("coinDecreaseFuel2", coinDecreaseFuel);
                //
                
                break;
            case 2:
                PlayerPrefs.SetFloat("speed3", speed);
                PlayerPrefs.SetFloat("durability3", durability);
                PlayerPrefs.SetFloat("duration3", duration);


                //

                PlayerPrefs.SetInt("rigidity3", rigidity);
                PlayerPrefs.SetInt("engine3", engine);
                PlayerPrefs.SetInt("wing3", wing);
                PlayerPrefs.SetInt("accelerate3", accelerate);
                PlayerPrefs.SetInt("fuel3", fuel);

                //
                PlayerPrefs.SetInt("coinDecreaseRigiditiy3", coinDecreaseRigidity);
                PlayerPrefs.SetInt("coinDecreaseEngine3", coinDecreaseEngine);
                PlayerPrefs.SetInt("coinDecreaseWing3", coinDecreaseWing);
                PlayerPrefs.SetInt("coinDecreaseAccelerate3", coinDecreaseAcclerate);
                PlayerPrefs.SetInt("coinDecreaseFuel3", coinDecreaseFuel);
                //
                
                break;

            case 3:
                PlayerPrefs.SetFloat("speed4", speed);
                PlayerPrefs.SetFloat("durability", durability);
                PlayerPrefs.SetFloat("duration", duration);


                //

                PlayerPrefs.SetInt("rigidity4", rigidity);
                PlayerPrefs.SetInt("engine4", engine);
                PlayerPrefs.SetInt("wing4", wing);
                PlayerPrefs.SetInt("accelerate4", accelerate);
                PlayerPrefs.SetInt("fuel4", fuel);

                //
                PlayerPrefs.SetInt("coinDecreaseRigiditiy4", coinDecreaseRigidity);
                PlayerPrefs.SetInt("coinDecreaseEngine4", coinDecreaseEngine);
                PlayerPrefs.SetInt("coinDecreaseWing4", coinDecreaseWing);
                PlayerPrefs.SetInt("coinDecreaseAccelerate4", coinDecreaseAcclerate);
                PlayerPrefs.SetInt("coinDecreaseFuel4", coinDecreaseFuel);
                //
                
                break;
            default:
                break;
        }
        /*PlayerPrefs.SetFloat("speed",speed);
        PlayerPrefs.SetFloat("durability", durability);
        PlayerPrefs.SetFloat("duration", duration);


        //

        PlayerPrefs.SetInt("rigidity", rigidity);
        PlayerPrefs.SetInt("engine", engine);
        PlayerPrefs.SetInt("wing", wing);
        PlayerPrefs.SetInt("accelerate", accelerate);
        PlayerPrefs.SetInt("fuel", fuel);

        //
        PlayerPrefs.SetInt("coinDecreaseRigiditiy", coinDecreaseRigidity);
        PlayerPrefs.SetInt("coinDecreaseEngine", coinDecreaseEngine);
        PlayerPrefs.SetInt("coinDecreaseWing", coinDecreaseWing);
        PlayerPrefs.SetInt("coinDecreaseAccelerate", coinDecreaseAcclerate);
        PlayerPrefs.SetInt("coinDecreaseFuel", coinDecreaseFuel);
        //
        PlayerPrefs.SetInt("Coin", coin);*/
        
    }
    void CoinPrefsFunc()
    {
        switch (shipLevel)
        {
            case 0:
                coinDecreaseRigidity = PlayerPrefs.GetInt("coinDecreaseRigiditiy");
                coinDecreaseEngine = PlayerPrefs.GetInt("coinDecreaseEngine");
                coinDecreaseWing = PlayerPrefs.GetInt("coinDecreaseWing");
                coinDecreaseAcclerate = PlayerPrefs.GetInt("coinDecreaseAccelerate");
                coinDecreaseFuel = PlayerPrefs.GetInt("coinDecreaseFuel");
                break;
            case 1:
                coinDecreaseRigidity = PlayerPrefs.GetInt("coinDecreaseRigiditiy2");
                coinDecreaseEngine = PlayerPrefs.GetInt("coinDecreaseEngine2");
                coinDecreaseWing = PlayerPrefs.GetInt("coinDecreaseWing2");
                coinDecreaseAcclerate = PlayerPrefs.GetInt("coinDecreaseAccelerate2");
                coinDecreaseFuel = PlayerPrefs.GetInt("coinDecreaseFuel2");
                break;
            case 2:
                coinDecreaseRigidity = PlayerPrefs.GetInt("coinDecreaseRigiditiy3");
                coinDecreaseEngine = PlayerPrefs.GetInt("coinDecreaseEngine3");
                coinDecreaseWing = PlayerPrefs.GetInt("coinDecreaseWing3");
                coinDecreaseAcclerate = PlayerPrefs.GetInt("coinDecreaseAccelerate3");
                coinDecreaseFuel = PlayerPrefs.GetInt("coinDecreaseFuel3");
                break;
            case 3:
                coinDecreaseRigidity = PlayerPrefs.GetInt("coinDecreaseRigiditiy4");
                coinDecreaseEngine = PlayerPrefs.GetInt("coinDecreaseEngine4");
                coinDecreaseWing = PlayerPrefs.GetInt("coinDecreaseWing4");
                coinDecreaseAcclerate = PlayerPrefs.GetInt("coinDecreaseAccelerate4");
                coinDecreaseFuel = PlayerPrefs.GetInt("coinDecreaseFuel4");
                break;
        }
        coin = PlayerPrefs.GetInt("Coin");
        
    }
    void SpecCheck()
    {

        speed = (wing / 2) + (engine);
        durability = (rigidity) + (wing);
        duration = (rigidity / 2) + (fuel);
    }
    public void RigidityUpgrade()
    {
        if (rigidity < maxValue && 0 <= coin - coinDecreaseRigidity)
        {
            coin -= coinDecreaseRigidity;
            coinDecreaseRigidity *= 2;
            rigidity++;
        }
        

    }
    public void EngineUpgrade()
    {
        if (engine < maxValue && 0 <= coin - coinDecreaseEngine)
        {
            coin -= coinDecreaseEngine;
            coinDecreaseEngine *= 2;
            engine++;
        }
        

    }
    public void WingUpgrade()
    {
        if (wing < maxValue && 0 <= coin - coinDecreaseWing)
        {
            coin -= coinDecreaseWing;
            coinDecreaseWing *= 2;
            wing++;
        }
        

    }
    public void AccelerateUpgrade()
    {
        if (accelerate < maxValue && 0 <= coin - coinDecreaseAcclerate )
        {
            coin -= coinDecreaseAcclerate;
            coinDecreaseAcclerate *= 2;
            accelerate++;
        }
        

    }
    public void FuelUpgrade()
    {
        if (fuel < maxValue && 0 <= coin - coinDecreaseFuel)
        {
            coin -= coinDecreaseFuel;
            coinDecreaseFuel *= 2;
            fuel++;
        }
    }
}
