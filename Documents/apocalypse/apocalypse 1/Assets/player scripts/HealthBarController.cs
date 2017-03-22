using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    private Slider healthBar;
    private int currentHP = 100;

    void Awake()
    {
        healthBar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = currentHP;
    }

    public void changeHP(int diffHP)
    {
        currentHP += diffHP;
    }

}
