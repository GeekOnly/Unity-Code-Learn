using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ColorScript : MonoBehaviour
{
    Renderer _renderer;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        //_renderer.sharedMaterial.color = Color.red;
        _renderer.material.color = Color.red;
    }
}
