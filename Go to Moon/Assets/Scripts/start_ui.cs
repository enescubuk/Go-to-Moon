using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start_ui : MonoBehaviour
{
    float rotateSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,15 * Time.deltaTime * rotateSpeed);
    }

    public void garageButton()
    {
        SceneManager.LoadScene("Garage");
    }
    public void purchaseButton()
    {
        SceneManager.LoadScene("Purchase");
    }
    public void leaderboardsButton()
    {
        SceneManager.LoadScene("LeaderBoards");
    }
    public void settingsButton()
    {
        SceneManager.LoadScene("Options");
    }
}
