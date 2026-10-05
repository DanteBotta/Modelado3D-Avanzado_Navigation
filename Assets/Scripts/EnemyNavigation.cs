using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform destination;

    [Header("Arrays (se autocompletan)")]
    public DamagePointBox[] Boxs;
    public Enemy[] enemies;

    [Header("Referencia al script enemy (se autocompletan)")]
    public Enemy Enemy;

    int CajaRandom;
    int EnemigoRandom;

    // Start is called before the first frame update
    void Start()
    {
        Boxs = FindObjectsOfType <DamagePointBox>();
        enemies = FindObjectsOfType<Enemy>();

        Enemy = GetComponent<Enemy>();
        agent = GetComponent<NavMeshAgent>();
        
        CajaRandom = Random.Range(0, Boxs.Length);
        EnemigoRandom = ReturnRandomNumberExceptThis();

        destination = Boxs[CajaRandom].transform;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = destination.position;

        if (Mathf.Abs(transform.position.x - destination.position.x) < 1f && Mathf.Abs(transform.position.z - destination.position.z) < 1f)
        {
            SetDamagePointTo(Boxs[CajaRandom].DamagePoint);
            destination = enemies[EnemigoRandom].transform;
        }
    }

    void SetDamagePointTo(int val)
    {
        Enemy.damagePoints = val;
    }

    int ReturnRandomNumberExceptThis()
    {
        int EnemigoRandom = Random.Range(0, enemies.Length);

        while (enemies[EnemigoRandom] == Enemy)
        {
            EnemigoRandom = Random.Range(0, enemies.Length);
        }

        return EnemigoRandom;
    }
}
