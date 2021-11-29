using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public int id;
    public string username;
    public float health;
    public float maxHealth = 100f;
    public int itemCount = 0;
    public GameObject model;
    public bool isLocal;
    public Text usernameText;
    public Slider healthSlider;
    public Image[] hudGrenades;


    public void Initialize(int _id, string _username)
    {
        id = _id;
        username = _username;
        health = maxHealth;

        if (!isLocal)
        {
            usernameText.text = username;
        }

    }

    public void SetHealth(float _health)
    {
        health = _health;

        healthSlider.value = health / 100;

        if (health <= 0f)
        {
            Die();
        }
    }

    public void Die()
    {
        model.SetActive(false);
    }

    public void Respawn()
    {
        model.SetActive(true);
        SetHealth(maxHealth);
    }

    public void addHUDGrenade()
    {
        for (int i = 0; i < hudGrenades.Length; i++)
        {
            hudGrenades[i].enabled = false;
        }

        for (int i = 0; i < itemCount; i++)
        {
            hudGrenades[i].enabled = true;
        }
    }
}
