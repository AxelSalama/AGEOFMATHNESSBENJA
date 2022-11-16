using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PosData", menuName = "crearPosData")]
public class PosicionData : ScriptableObject
{
    public Vector3 posicionFinal;
    public bool posicionado;
}
