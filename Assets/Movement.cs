using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 10)
        {
            transform.Translate(10f * Vector3.right  * Time.deltaTime, Space.World);
           
            if(transform.rotation.z > -0.34)
                transform.Rotate(Vector3.back * 140 * Time.deltaTime);
           
        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -10)
        {
            transform.Translate(10f * Vector3.left * Time.deltaTime, Space.World);

            if (transform.rotation.z < 0.34)
                transform.Rotate(Vector3.forward * 140 * Time.deltaTime);
        }

        else if (transform.rotation.z < 0)
        {
            transform.Rotate(Vector3.forward * 70* Time.deltaTime);
        }

        else if (transform.rotation.z > 0)
        {
            transform.Rotate(Vector3.back * 70 * Time.deltaTime);
        }

        Debug.Log(transform.rotation.z);

       

            
    }
}
