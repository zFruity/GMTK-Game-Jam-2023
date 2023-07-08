using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;
    [SerializeField] private SpriteRenderer _renderer;

    public void Color(bool isOffset)
    {
        _renderer.color = isOffset ? offsetColor : baseColor;
    }
    void Start()
    {

    }
}
