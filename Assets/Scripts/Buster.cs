using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buster : MonoBehaviour
{
    [SerializeField] private SpawnEnemys spawn;
    public GameObject[] boom = new GameObject[14];
    public GameObject enem;

    public int boomDead;

    void Update()
    {
        // boomDead = 1;
        boomDead = PlayerPrefs.GetInt("Boom");
    }

    public void Boom()
    {
        boomDead = 0;
        PlayerPrefs.SetInt("Boom", boomDead);
        PlayerPrefs.SetInt("count", boomDead);
        print("boom" + PlayerPrefs.GetInt("count"));
    }

    public void Spawn()
    {
        PlayerPrefs.SetInt("spawn", 3);
    }
}
