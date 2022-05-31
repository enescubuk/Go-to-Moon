using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class bgControl : MonoBehaviour
{
    
    public shipController _shipController;
    public Animator Animator;

    void Update()
    {
        
        if (_shipController.heightSlider.value > 12 && _shipController.heightSlider.value < 13)
        {
            Animator.SetTrigger("bg1");
        }
        if (_shipController.heightSlider.value > 37 && _shipController.heightSlider.value < 38 )
        {
            Animator.SetTrigger("bg2");
        }
        if (_shipController.heightSlider.value > 83 && _shipController.heightSlider.value < 84)
        {
            Animator.SetTrigger("bg3");
        }
    }
}
