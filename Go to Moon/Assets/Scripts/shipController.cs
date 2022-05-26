using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shipController : MonoBehaviour
{
    private Rigidbody2D rb;
    
    public Slider heightSlider;
    public float speed;
    public int coin;
    public Text coinText;
    public int deadCount; // BIRD,HELICOPTER, BALOON
    public float fuel;
    public Vector2 shipStartPosition;
    public float dist;
    public float shipHot;
    public bool shipHotControl;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        Vector3 position = transform.position;
        Vector2 movement = new Vector2(hor * speed,position.y+=(speed/100));
        rb.AddForce(movement);
        transform.position = position;
        rb.drag = 4;
    }

    void Update()
    {
        anger();
        shipDistance();
        shipHotCont();
        fuel +=0.1f;

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
            fuel = 0;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Oil")
        {
            if (fuel<=45)
            {
                fuel = 0;
            }else
            {
                fuel -= 45;
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
        shipHotControl = true;
    }

    public void SpeedUpButtonExit()
    {
        speed /= 2;
        shipHotControl = false;
    }

    void shipDistance()
    {
        dist = Vector2.Distance(shipStartPosition, gameObject.transform.position);
        heightSlider.value = dist;
    }

    void shipHotCont()
    {
        if (shipHotControl == true)
        {
            shipHot += 0.1f;
        }else if (shipHotControl == false)
        {
            if (shipHot !>0)
            {
                shipHot -= 0.1f;
            }
            
        }

        if (shipHot>=100)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
