using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ItemData",menuName ="CrearEnemyData")]
public class EnemyData : ScriptableObject
{
    public bool derrotado = false;
    public int orden;
}
