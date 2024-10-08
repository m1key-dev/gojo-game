using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    [SerializeField]
    private float maxHealth = 100f;
    public float currentHealth;

    public healthBar healthBar;
    Animator animator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        healthBar.SetSliderMax(maxHealth);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Die();
        }
    } //kdyz nejsou hpka, propojit s player controllerem a zastavit pohyb (dat podminku na pohyb = currentHealth > 0)

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.SetSlider(currentHealth);
    }

    public void Die()
    {
        animator.SetBool("moveLeft", false);
        animator.SetBool("moveRight", false);
        animator.SetBool("isDead", true);
    }
}
