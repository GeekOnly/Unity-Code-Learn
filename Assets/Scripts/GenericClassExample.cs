using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExample : MonoBehaviour
{
    private void Start()
    {
        GenericClass<int> MyClass = new GenericClass<int>();

        MyClass.UpdateItem(5);
    }
}
