using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleB : FruitB
{
    public AppleB()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    public new void Chop()
    {
        Debug.Log("The apple has been chopped.");
    }

    public new void SayHello()
    {
        Debug.Log("Hello, I am an apple.");
    }
}
