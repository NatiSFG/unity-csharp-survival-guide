using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Create 2 properties for Speed (read only) and for Name (public). Practice using auto
//properties as well as delcaring them. When declaring them, use Debug lines to know
//when the properties are being called.
public class DeclaringProperties : MonoBehaviour {

    public int Speed { get; private set; }

    public string Name { get; set; }

    private void Start() {
        Speed = 4;
        Debug.Log("Speed is " + Speed);

        Name = "Natalia";
        Debug.Log("My name is " + Name);
    }

}
