﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] int maxHealth = 10;
    [SerializeField] int curHealth;
    [SerializeField] float regenerationRate = 2f;
    [SerializeField] int regenerateAmount = 1;

    private void Start()
    {
        curHealth = maxHealth;

        InvokeRepeating("Regenerate", regenerationRate, regenerationRate);
    }

    void Regenerate() {
        if (curHealth < maxHealth) {
            curHealth += regenerateAmount;
        }
        if (curHealth > maxHealth) {
            curHealth = maxHealth;
            CancelInvoke();
        }
    }

    public void TakeDamage(int dmg = 1) {
        curHealth -= dmg;
        if (curHealth < 1)
            Debug.Log("I B DED");
    }
}