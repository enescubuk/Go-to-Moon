using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgControl : MonoBehaviour
{
    public shipController _shipController;
    public Animator Animator;
    void Start()
    {
    }

    void Update()
    {
        if (_shipController.dist >= 10 && _shipController.dist <=10.5f)
        {
            Animator.SetTrigger("bg1");
        }
        if (_shipController.dist >= 15 && _shipController.dist <=15.5f)
        {
            Animator.SetTrigger("bg2");
        }
        if (_shipController.dist >= 20 && _shipController.dist <=20.5f)
        {
            Animator.SetTrigger("bg3");
        }
    }
}
