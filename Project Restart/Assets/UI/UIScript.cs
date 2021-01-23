using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // need this to for the script to communicate with the UI

public class UIScript : MonoBehaviour
{

    public Health healthScript;
    public Text healthTxt;
    public Slider healthBar;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.maxValue = healthScript.getMaxHealth();
        healthBar.value = healthScript.getHealth();
        healthTxt.text = "Health: " + healthScript.getHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
