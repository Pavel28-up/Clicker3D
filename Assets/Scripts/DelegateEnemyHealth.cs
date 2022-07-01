using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelegateEnemyHealth : MonoBehaviour
{
    public delegate void DelegateEnemyHealthDamage(DelegateEnemyHealth p);
    public event DelegateEnemyHealthDamage playerDamageEvent;
    public int damage;
    public int count;
    public int enem;
    public int enemRec;

    private Enemy _health;

    void Start()
    {
        _health = GetComponent<Enemy>();
        PlayerPrefs.SetInt("Boom", 1);
        if (PlayerPrefs.GetInt("level") == 0)
        {
            PlayerPrefs.SetInt("damag", damage);
        }
        else
        {
            damage = PlayerPrefs.GetInt("damag");
            PlayerPrefs.SetInt("damag", damage);
        }
    }

    void Update()
    {
        enemRec = PlayerPrefs.GetInt("deadRecord");
        Booms();
        count = PlayerPrefs.GetInt("count");
        damage = PlayerPrefs.GetInt("damag");
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
#if !UNITY_EDITOR
            if (Input.GetTouch(0).phase != TouchPhase.Began)
                return;
#endif
            
            Damage();
            if (_health.health <= 0)
            {
                enem = PlayerPrefs.GetInt("dead");
                enem++;
                enemRec++;
                PlayerPrefs.SetInt("deadRecord", enemRec);
                PlayerPrefs.SetInt("dead", enem);
                count--;
                PlayerPrefs.SetInt("count", count);
                Destroy(gameObject);
            }
        }
    }

    public void Damage()
    {
        playerDamageEvent(this);
        _health.health -= damage;
    }

    public void Booms()
    {
        if (PlayerPrefs.GetInt("Boom") == 0)
        {
            _health.health -= 100;
            if (_health.health <= 0)
            {
                enem = PlayerPrefs.GetInt("dead");
                enem++;
                enemRec++;
                PlayerPrefs.SetInt("deadRecord", enemRec);
                PlayerPrefs.SetInt("dead", enem);
                count -= count;
                PlayerPrefs.SetInt("count", count);
                Destroy(gameObject);
            }
        }
    }
}
