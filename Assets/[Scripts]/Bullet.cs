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
// 
//==================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Bullet Manager")]
    public GameObject bulletSpawnPoint;
    public GameObject playerLocation;
    public float speed = 10.0f;


    private float bulletSpawnXPos;
    private float playerLocXPos;

    private float distance;
    private float nextXPos;
    private float bottomBoundYPos;
    private float height;
    private float shootBotmTarget;


    // Start is called before the first frame update
    void Start()
    {

        //attaching by tag the transforms of player and eagle bullet spawnpointgameobject
        bulletSpawnPoint = GameObject.FindGameObjectWithTag("EagleEnemy");
        playerLocation = GameObject.FindGameObjectWithTag("Player");
       
     
    }

    // Update is called once per frame
    void Update()
    {
        bulletSpawnXPos = bulletSpawnPoint.transform.position.x;
        playerLocXPos = playerLocation.transform.position.x;
        

        distance = playerLocXPos - bulletSpawnXPos;
        nextXPos = Mathf.MoveTowards(transform.position.x, playerLocXPos, speed * Time.deltaTime);
        bottomBoundYPos = Mathf.Lerp(bulletSpawnPoint.transform.position.y, playerLocation.transform.position.y, (nextXPos - bulletSpawnXPos) / distance);
        height = 2 * (nextXPos - bulletSpawnXPos) * (nextXPos - playerLocXPos) / (-0.25f * distance * distance); // Arc moment for the bullet

        Vector3 movePosisionV = new Vector3(nextXPos, bottomBoundYPos + height, transform.position.z);
        transform.position = movePosisionV;

        if (transform.position.x == playerLocation.transform.position.x)
        {
            Destroy(gameObject);
        }
    
    }

}
