// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : OCT 18, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT2_Part1
// SPECIAL NOTES:
// ===============================
// Change History:
// Added bullets for flying eagle enemy with shooting capability
//==================================
//==================================
// Change History:
// Added player location as target for the bullet to move to after spawning
//==================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Bullet Manager")]
    GameObject bulletSpawnPoint;
    public float speed = 5.0f;
    public int damage = 1;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //only one check in start so the bullet doesn't keep following the player.
        rb = GetComponent<Rigidbody2D>();
        bulletSpawnPoint = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDir = (bulletSpawnPoint.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDir.x, moveDir.y);
        Destroy(this.gameObject, 2);
      

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Health player = other.GetComponent<Health>();

        if(player != null)
        {
            player.TakeDamage(damage);
        }

        Destroy(gameObject);
    }

}
