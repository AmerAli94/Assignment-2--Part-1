using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfLives;

    public Image[] lives;
    public Sprite remainingLives;
    public Sprite emptyLifeSlots;



    // Update is called once per frame
    void Update()
    {
        if(health > numOfLives)
        {
            health = numOfLives;
        }

        for (int i= 0; i < lives.Length; i++)
        {
            if(i< health)
            {
                lives[i].sprite = remainingLives;
           
            }
            else
            {
                lives[i].sprite = emptyLifeSlots;
            }

            if (i < numOfLives)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }
        }
    }
     public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Debug.Log("Game over");
        }
    }
}
