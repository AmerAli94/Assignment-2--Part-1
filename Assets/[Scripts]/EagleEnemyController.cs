// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : OCT 18, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT2_Part1
// SPECIAL NOTES:
// ===============================
// Change History:
// Added shooting eagle enemy with trajactery like falling bullets
//==================================
//==================================
// Change History:
// 
//==================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EagleEnemyController : MonoBehaviour
{
    public float timeBwShots;

    [Header("Bullets")]
    public GameObject bullet;
    public Transform shootingPos;
    public float shootingSpeed;

    private bool CanShoot;

    private void Start()
    {
        
        
        CanShoot = true;
       
    }

    private void Update()
    {
        if (CanShoot)
        {
            StartCoroutine(Shoot());

        }
    }

    IEnumerator Shoot()
    {
        CanShoot = false;
        yield return new WaitForSeconds(timeBwShots);
        GameObject newBullet = Instantiate(bullet, shootingPos.position, Quaternion.identity);

        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootingSpeed * Time.deltaTime, 0.0f);
        Debug.Log("Shoot");
        CanShoot = true;

    }
}
