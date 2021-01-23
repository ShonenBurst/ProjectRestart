using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int maximumHealth = 100;
    [SerializeField] int currentHealth = 0;

    void Start() {
        currentHealth = maximumHealth;
    }

    public bool IsDead { get { return currentHealth <= 0;  } }
    // Update is called once per frame
    public int getHealth()
    {
        return currentHealth;
    }

    public int getMaxHealth()
    {
        return maximumHealth;
    }

    public void Damage(int damageValue)
    {
        currentHealth -= damageValue;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
