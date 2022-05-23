using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shipController : MonoBehaviour
{
    private Rigidbody2D rb;

    public fuelIndicator FuelIndicator;
    public Slider heightSlider;
    public float speed;
    public int coin;
    public Text coinText;
    public int deadCount; // BIRD,HELICOPTER, BALOON
    public float fuel;
    public Vector2 shipStartPosition;
    public float dist;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        Vector3 position = transform.position;
        Vector2 movement = new Vector2(hor * speed,position.y+=(speed/100));
        rb.AddForce(movement);
        transform.position = position;
        anger();
        shipDistance();
        fuel = dist * 5;
    }
    void anger()
    {
        if (transform.position.x == -2.35f && transform.position.x== 2.35f)
        {
            rb.velocity = new Vector2(0,0);
        }
        float xPosition = Mathf.Clamp(transform.position.x, -2.35f, 2.35f);
        transform.position = new Vector3(xPosition, transform.position.y,transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Coin")
        {
            coin +=5;
            coinText.text = "" + coin;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Bird")
        {
            deadCount += 1;
            if (deadCount>3)
            {
                deadCount = 0;
            }
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "GasTank")
        {
            fuel = 100;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Oil")
        {
            if (fuel<=75)
            {
                fuel += 25;
            }else
            {
                fuel = 100;
            }
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Helicopter")
        {
            deadCount += 1;
            if (deadCount>3)
            {
                deadCount = 0;
            }
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Balloon")
        {
            deadCount += 1;
            if (deadCount>3)
            {
                deadCount = 0;
            }
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Technic")
        {
            deadCount = 0;
            Destroy(col.gameObject);
        }
    }

    public void SpeedUpButton()
    {
        speed *= 2;
    }

    public void SpeedUpButtonExit()
    {
        speed = 1;
    }

    void shipDistance()
    {
        dist = Vector2.Distance(shipStartPosition, gameObject.transform.position);
        heightSlider.value = dist;
    }
}
