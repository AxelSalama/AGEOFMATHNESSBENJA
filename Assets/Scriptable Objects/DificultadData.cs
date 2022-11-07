using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "CrearDificultadData")]
public class DificultadData : ScriptableObject
{
    public bool facil;
    public bool dificil;
    public bool imposible;
}
