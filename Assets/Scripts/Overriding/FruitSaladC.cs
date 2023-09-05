using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladC : MonoBehaviour
{
    private void Start()
    {
        AppleC myApple = new AppleC();

        myApple.SayHello();
        myApple.Chop();

        FruitC myFruit = new AppleC();
        myFruit.SayHello();
        myFruit.Chop();
    }
}
