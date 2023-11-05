using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipFalling : MonoBehaviour
{
    
    GameObject instSpaceShip;
    float rightOrLeft;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SendProjectile", 1.0f, 3.0f);
        rightOrLeft = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SendProjectile()
    {
        rightOrLeft++;
        Debug.Log("It works!!!!");
       
        float rangeX = Random.Range(-10, 10);
        float rangeShip = Random.Range(3, 8);


        for (int i = 0; i < rangeShip; i++)
        {
            instSpaceShip = Instantiate(GameObject.Find("rocket"));
            
            instSpaceShip.transform.position = new Vector3(rangeX, 0, 13+i*2);

            if (rightOrLeft % 2 == 1)
                instSpaceShip.AddComponent<ShipMovementLeft>();
            else
                instSpaceShip.AddComponent<ShipMovementRight>(); 

        }
        
      
    }

    


}
