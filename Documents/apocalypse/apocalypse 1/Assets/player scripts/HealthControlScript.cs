using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// if timeControlledHealthBar is ticked, then the health bar decreases by damage (1)  every seconds.
public class HealthControlScript : MonoBehaviour {
    private HealthBarController healthBar;

    public bool timeControlledHealthBar;
    private float timeStarted;
    void Awake()
    {
        timeStarted = Time.time;
        healthBar = GameObject.Find("Health Bar").GetComponent<HealthBarController>();
    }

    void Update()
    {
        if (timeControlledHealthBar)
        {
            if ((Time.time - timeStarted) >= 1.00)
            {
                timeStarted = Time.time;
                healthBar.changeHP(-1);
            }
        }
        else
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {
                healthBar.changeHP(1);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                healthBar.changeHP(-1);
            }
        }
    }
}
