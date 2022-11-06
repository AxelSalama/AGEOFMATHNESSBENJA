using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barraVidaEnemigo : MonoBehaviour
{
    private Slider slider;
    public EnemyLife enemylife;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = enemylife.health;
    }
}
