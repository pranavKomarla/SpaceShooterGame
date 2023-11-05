using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementLeft : MonoBehaviour
{
    public Transform myChildObject;
    public ParticleSystem myChildObjectParticleSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z > 7)
            transform.Translate(5f * Vector3.up * Time.deltaTime);

        else
        {
            transform.Translate(5f * Vector3.up * Time.deltaTime);
            transform.Translate(5f * Vector3.right * Time.deltaTime); 
        }

        if (transform.position.x > 9.5)
        {
            transform.Translate(5f * Vector3.up * Time.deltaTime);
        }

        if (transform.position.z < -5f) Destroy(this.gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("yay");
        Destroy(collision.gameObject);
        myChildObject = transform.GetChild(1);
        myChildObject.parent = null;
        myChildObject.gameObject.SetActive(true);
        myChildObjectParticleSystem = myChildObject.gameObject.GetComponent<ParticleSystem>();

        myChildObjectParticleSystem.Play(true);


        Destroy(this.gameObject);
        Destroy(myChildObject.gameObject, 2);
    }
}
