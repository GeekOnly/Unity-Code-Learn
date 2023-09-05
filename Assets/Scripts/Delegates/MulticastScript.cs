using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulticastScript : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate _myMultiDelegate;

    Renderer _renderer;

    private void Start()
    {
        _myMultiDelegate += PowerUp;
        _myMultiDelegate += TurnRed;

        if(_myMultiDelegate != null)
        {
            _myMultiDelegate();
        }
    }

    void PowerUp()
    {
        print("Orb is powering up!");
    }

    void TurnRed()
    {
        _renderer.material.color = Color.red;   
    }
}
