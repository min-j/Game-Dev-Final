using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(TrailRenderer))]

public class Thruster : MonoBehaviour
{
    TrailRenderer tr;

    private void Awake()
    {
        tr = GetComponent<TrailRenderer>();
    }

    public void Activate(bool activate = true) {
        if (activate)
        {
            tr.enabled = true;
            //turn on partical effects
            //turn on sound
            //etv
        }
        else {
            tr.enabled = false;
            //turn everything off associated with thruster
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
