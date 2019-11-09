using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image currentHealthBar;
    public Text ratioText;

    private float Health = 150;
    private float maxHealth = 150;
    void Start()
    {
        BarColor();
        UpdateHealthBar();
    }

    void BarColor()
    {
        Renderer rend = GetComponent<Renderer>();

        if (Health < .3f)
        {
            //rend.material.SetColor("RedColor", Color.red);
        }
        else if (Health < .6f)
        {
            //rend.material.SetColor("OrangeColor", Color.yellow);
        }
        else
        {
            //rend.material.SetColor("GreenColor", Color.green);
        }
    }
    void UpdateHealthBar()
    {
        float ratio = Health / maxHealth;
        currentHealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text ="HP "+ (ratio * 100).ToString("") + '%';
    }

    private void TakeDamage(float damage)
    {
        Health -= damage;
        if(Health < 0)
        {
            Health = 0;
            Debug.Log("Dead!");
        }
        UpdateHealthBar();
        BarColor();
    }

    private void HealDamage(float heal)
    {
        Health += heal;
        if (Health > maxHealth)
        {
            Health = maxHealth;
            UpdateHealthBar();
            BarColor();
        }
    }
}
