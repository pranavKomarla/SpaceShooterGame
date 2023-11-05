using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject shooter;
    GameObject instShooter; 
    
    Rigidbody instShooterRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            instShooter = Instantiate(shooter, transform.position, Quaternion.identity) as GameObject;
            instShooterRigidBody = instShooter.GetComponent<Rigidbody>();
            instShooter.transform.position = new Vector3(transform.position.x, -1.0f, transform.position.z);

            instShooterRigidBody.AddForce(10f * transform.forward, ForceMode.Impulse);
            


        }

        

    }

    

}

