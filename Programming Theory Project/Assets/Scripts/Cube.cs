using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Target
{
    private Rigidbody cubeRb;

    // Start is called before the first frame update
    void Start()
    {
        cubeRb = GetComponent<Rigidbody>();
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
        float volume = Width * Width * Height;
        // ABSTRACTION
        ShowMessage("Cube", volume);
    }
}
