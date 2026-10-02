using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    public Enemy[] enemies;

    public int DamagePointDeseado;
    // Start is called before the first frame update
    void Start()
    {
        enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SetAllEnemiesDamagePointsTo(DamagePointDeseado);
        }
    }

    void SetAllEnemiesDamagePointsTo(int val)
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].damagePoints = val;
        }    
    }
}
