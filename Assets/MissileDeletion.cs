﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileDeletion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 10f)
            Destroy(this.gameObject); 
    }
}
