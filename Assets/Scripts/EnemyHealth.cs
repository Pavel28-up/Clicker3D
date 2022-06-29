using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<DelegateEnemyHealth>().playerDamageEvent += onPlayrDamage;
    }

    public void onPlayrDamage(DelegateEnemyHealth player) 
    {
    }
}
