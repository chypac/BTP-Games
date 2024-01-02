using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Castle : MonoBehaviour//хп йадра и хп бар
{
    public float totalHealth = 100f;
    public float currentHealth;

    public Slider healthSlider;
    public Transform[] attackPoints;
    void Start()
    {
        currentHealth = totalHealth;

        healthSlider.maxValue = totalHealth;
        healthSlider.value = currentHealth;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float damageToTake)
    {
        currentHealth -= damageToTake;

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
        healthSlider.value = currentHealth;
    }
}

