using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    [SerializeField]
    private float height;
    [SerializeField]
    private float width;
    public GameObject goal;
    public Text volumeText;
    // ENCAPSULATION
    public float Height { get => height; set => height = value; }
    public float Width { get => width; set => width = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void CalculateVolume()
    {
        float volume = Width * Height;
        ShowMessage("Target", volume);
    }

    public void ShowMessage(string figure, float volume)
    {
        string message = "The " + figure + " volume is: " + volume;
        Debug.Log(message);
        volumeText.text = message; 
    }
}
