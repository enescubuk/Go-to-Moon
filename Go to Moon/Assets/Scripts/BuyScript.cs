using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyScript : MonoBehaviour
{
    public bool isBuyCoin, isBuy3Euro, isBuy5Euro;
    [SerializeField] GameObject[] images;

   public float BuyReset, BuyReset3, BuyReset5;
    private void Awake()
    {
        BuyReset = PlayerPrefs.GetFloat("BuyCoin");
        BuyReset3 = PlayerPrefs.GetFloat("Buy3Euro");
        BuyReset5 = PlayerPrefs.GetFloat("Buy5Euro");
    }
    public void BuyCoin()
    {
        BuyReset = 1;
        PlayerPrefs.SetFloat("BuyCoin",1);

    }
    public void Buy3Euro()
    {

        BuyReset3 = 1;
        PlayerPrefs.SetFloat("Buy3Euro", 1);
    }
    public void Buy5Euro()
    {
        BuyReset5 = 1;
        //images[2].SetActive(false);
        PlayerPrefs.SetFloat("Buy5Euro", 1);

    }
 
    void Start()
    {
        PlayerPrefs.SetFloat("BuyCoin", BuyReset);
        PlayerPrefs.SetFloat("Buy3Euro", BuyReset3);
        PlayerPrefs.SetFloat("Buy5Euro", BuyReset5);
    }

    void Update()
    {
        
        if (PlayerPrefs.GetFloat("BuyCoin")==1)
        {
            images[0].SetActive(false);
        }
        if (PlayerPrefs.GetFloat("Buy3Euro") == 1)
        {
            images[1].SetActive(false);
        }
        if (PlayerPrefs.GetFloat("Buy5Euro") == 1)
        {
            images[2].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.SetFloat("BuyCoin", 0);
            PlayerPrefs.SetFloat("Buy3Euro", 0);
            PlayerPrefs.SetFloat("Buy5Euro", 0);
        }
    }
}
