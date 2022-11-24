using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Target
{
    private Rigidbody cylinderRb;

    // Start is called before the first frame update
    void Start()
    {
        cylinderRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == goal)
        {
            CalculateVolume();
            Destroy(gameObject);
        }
    }

    // POLYMORPHISM
    private void CalculateVolume()
    {
        float volume = (float)(Math.Pow((Width / 2), 2) * Math.PI * Height);
        // ABSTRACTION
        ShowMessage("Cylinder", volume);
    }
}
