using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    [Header("==OBJECT PREFAB==")]
    public GameObject coinPrefab;
    public GameObject birdPrefab;
    public GameObject gasTankPrefab;
    public GameObject oilPrefab;
    public GameObject technicPrefab;
    public GameObject balloonPrefab;
    public GameObject helicopterPrefab;
    [Header("==NUMBER OF OBJECT==")]
    public int numberOfCoins = 200;
    public int numberOfBirds = 200;
    public int numberOfGasTank = 200;
    public int numberOfOil = 200;
    public int numberOfTechnic = 200;
    public int numberOfBalloon = 200;
    public int numberOfHelicopter = 200;
    [Header("==LEVEL ORDER==")]
    public float levelWidth = 2.3f;
    public float minY= .2f;
    public float maxY= 1.5f;
    
    void Start()
    {
        coinInstantiate();
        birdInstantiate();
        GasTankInstantiate();
        oilInstantiate();
        technicInstantiate();
        balloonInstantiate();
        helicopterInstantiate();
    }

    void coinInstantiate()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfCoins; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        }
    }
    void birdInstantiate()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfBirds; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(birdPrefab, spawnPosition, Quaternion.identity);
        }
    }
    void GasTankInstantiate()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfGasTank; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(gasTankPrefab, spawnPosition, Quaternion.identity);
        }
    }
    void oilInstantiate()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfOil; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(oilPrefab, spawnPosition, Quaternion.identity);
        }
    }
    void technicInstantiate()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfTechnic; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(technicPrefab, spawnPosition, Quaternion.identity);
        }
    }
    void balloonInstantiate()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfBalloon; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(balloonPrefab, spawnPosition, Quaternion.identity);
        }
    }
    void helicopterInstantiate()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfHelicopter; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(helicopterPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
