using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "CrearPotionData")]
public class PotionData : ScriptableObject
{
    public int contador = 0;
    public bool isgrabbed;
    public GameObject Pota;
}
