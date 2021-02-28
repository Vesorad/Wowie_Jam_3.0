using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public SliderController sliderController;
    void Start()
    {
        currentHealth = maxHealth;
        sliderController.SetMaxHealth(maxHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Enemy")
        {
            //Debug.Log(gameObject.name +"  "+collision.gameObject.name);
            TakeDamage(1);
        }
    }
    void Update()
    {

    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        sliderController.SetHealth(currentHealth);
    }
}
