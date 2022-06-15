using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ShipChanger : MonoBehaviour
{
    public int CurrentShip;

    [SerializeField] GameObject[] Rockets;

    [SerializeField] GameObject[] BuyThings;
    private void Awake()
    {
        CurrentShip = PlayerPrefs.GetInt("currentShip");
    }
    void Start()
    {
        
    }
   public void ChangeLeft() 
    {
        
        if (CurrentShip == 0)
        {
            CurrentShip = 3;
        }
        else if(CurrentShip == 1)
        {
            CurrentShip = 0;
        }
        else if(CurrentShip == 2)
        {
            CurrentShip = 1;
        }
        else if (CurrentShip == 3)
        {
            CurrentShip = 2;
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
   public void ChangeRight()
    {
        
        if (CurrentShip == 0)
        {
            CurrentShip = 1;
        }
        else if(CurrentShip == 1)
        {
            CurrentShip = 2;
        }
        else if (CurrentShip == 2)
        {
            CurrentShip = 3;
        }
        else if (CurrentShip == 3)
        {
            CurrentShip = 0;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    void Update()

    {
        
        PlayerPrefs.SetInt("currentShip", CurrentShip);

        if (PlayerPrefs.GetFloat("BuyCoin") == 1)
        {
            BuyThings[0].SetActive(false);
        }
        if (PlayerPrefs.GetFloat("Buy3Euro") == 1)
        {
            BuyThings[1].SetActive(false);
        }
        if (PlayerPrefs.GetFloat("Buy5Euro") == 1)
        {
            BuyThings[2].SetActive(false);
        }

        if (CurrentShip == 0)
           
        {
            Rockets[0].SetActive(true);
            Rockets[1].SetActive(false);
            Rockets[2].SetActive(false);
            Rockets[3].SetActive(false);
            ///////////////////
            BuyThings[0].SetActive(false);
            BuyThings[1].SetActive(false);
            BuyThings[2].SetActive(false);
        }
        else if (CurrentShip == 1)
        {
            Rockets[0].SetActive(false);
            Rockets[1].SetActive(true);
            Rockets[2].SetActive(false);
            Rockets[3].SetActive(false);
            ///////////////////////
            BuyThings[0].SetActive(true);
            BuyThings[1].SetActive(false);
            BuyThings[2].SetActive(false);
        }
        else if (CurrentShip == 2)
        {
            Rockets[0].SetActive(false);
            Rockets[1].SetActive(false);
            Rockets[2].SetActive(true);
            Rockets[3].SetActive(false);
            ///////////////////////
            BuyThings[0].SetActive(false);
            BuyThings[1].SetActive(true);
            BuyThings[2].SetActive(false);
        }
        else if (CurrentShip == 3)
        {
            Rockets[0].SetActive(false);
            Rockets[1].SetActive(false);
            Rockets[2].SetActive(false);
            Rockets[3].SetActive(true);
            /////////////////////////
            BuyThings[0].SetActive(false);
            BuyThings[1].SetActive(false);
            BuyThings[2].SetActive(true);
        }
    }
}
