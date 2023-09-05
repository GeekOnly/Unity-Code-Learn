using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleC : FruitC
{
    public AppleC()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    public override void Chop()
    {
        base.Chop();
        Debug.Log("The Apple has been chopped.");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple.");
    }
}
