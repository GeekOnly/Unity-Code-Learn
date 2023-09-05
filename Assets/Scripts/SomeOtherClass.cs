using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    private void Start()
    {
        SomeClass myClass = new SomeClass();

        myClass.Add(1, 2);
        myClass.Add("Hello","World");

        myClass.GenericMethod<int>(5);
    }
}
