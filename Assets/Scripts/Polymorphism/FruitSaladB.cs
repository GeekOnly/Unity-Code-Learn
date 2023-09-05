using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladB : MonoBehaviour
{
    void Start()
    {
        FruitB myFruit = new AppleB();

        myFruit.SayHello();
        myFruit.Chop();

        AppleB MyApple = new AppleB();

        MyApple.SayHello();
        MyApple.Chop();
    }
}
