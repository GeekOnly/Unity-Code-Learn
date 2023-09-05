using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorScript : MonoBehaviour
{
    Renderer _renderer;
    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnEnable()
    {
        EventManager.OnClicked += TurnColor;
    }

    private void OnDisable()
    {
        EventManager.OnClicked -= TurnColor;
    }
    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        _renderer.material.color = col;
    }
}
