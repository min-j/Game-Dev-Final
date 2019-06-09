using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(TrailRenderer))]
[RequireComponent(typeof(Light))]

public class Thruster : MonoBehaviour
{
    //TrailRenderer tr;
    Light thrusterLight;

    private void Start()
    {
        //thrusterLight.enabled = false;
        //tr.enabled = false;
        thrusterLight.intensity = 0;
    }
    private void Awake()
    {
        //tr = GetComponent<TrailRenderer>();
        thrusterLight = GetComponent<Light>();
    }

    /*public void Activate(bool activate = true) {
        if (activate)
        {
            tr.enabled = true;
            thrusterLight.enabled = true;
            //turn on partical effects
            //turn on sound
            //etv
        }
        else {
            tr.enabled = false;
            thrusterLight.enabled = false;
            //turn everything off associated with thruster
        }
    }*/
    public void Intensity(float inten) {
        thrusterLight.intensity = inten * 2f;
    }

}
