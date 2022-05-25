using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonController : MonoBehaviour
{
    static string lastScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator startButtonDown()
    {
        GameObject.Find("Yellow startButtonBG").GetComponent<Animator>().SetTrigger("isTouch");
        yield return new WaitForSecondsRealtime(0.75f);
        SceneManager.LoadScene("Game"); 
    }

    public void mainMenuButton()
    {
        //main menü button
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
    public void startButton()
    {
        StartCoroutine(startButtonDown());
    }
    public void watchADSButton()
    {
        //watch ADS
    }
    public void restartButton()
    {
        //restart
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void backButton()
    {
        SceneManager.LoadScene(lastScene);
    }
    public void sfxButton()
    {
        //sfx open
    }
    public void musicButton()
    {
        //music on of
    }
    public void kmmileButton()
    {
        //change kmmile
    }
    public void languageButton()
    {
        //change language
    }
    public void lastScenewithButton()
    {
        lastScene = SceneManager.GetActiveScene().name;
    }
}
