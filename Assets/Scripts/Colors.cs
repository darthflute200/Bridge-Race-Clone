using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Colors : MonoBehaviour
{
    [SerializeField] public enum Color
    {
        Blue,
        Yellow,
        Green,
        Default
    }
    public Color CurrentColor;



}
