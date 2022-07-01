using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemys : MonoBehaviour
{
    [SerializeField] public GameObject enemyPrefab;
    public GameObject _enemy;
    public int _count;
    public int _damage;
    public int _tmp;
    public float _dead = 3.0f;
    public float _sec;
    private float _minSec;
    private float _maxSec;

    public GameObject Spawn;
    public GameObject panelGameOver;
    public GameObject but;
    public GameObject spawnSec;
    public Image bar;
    public Text levelText;
    public int count;
    public int levelCount;
    public float sec;
    public float minSec;
    public float maxSec;
    public float angleXmin;
    public float angleXmax;
    public float angleZmin;
    public float angleZmax;
    public bool lev = true;
    
    void Start()
    {
        but.SetActive(false);
        spawnSec.SetActive(false);
        _minSec = 1;
        _maxSec = 5;
        minSec = _minSec;
        maxSec = _maxSec;
        StartCoroutine(SpawnEnemy());

        PlayerPrefs.SetInt("level", 0);
        levelCount = PlayerPrefs.GetInt("level");
        levelText.text = "" + PlayerPrefs.GetInt("level") + "";

        PlayerPrefs.SetInt("dead", 0);
        _damage = PlayerPrefs.GetInt("damag");

        PlayerPrefs.SetFloat("deadCount", _dead);
        _dead = PlayerPrefs.GetFloat("deadCount");

        // PlayerPrefs.SetInt("count", 0);
        // _count = PlayerPrefs.GetInt("count");
        PlayerPrefs.SetInt("deadRecord", 0);
        
        panelGameOver.SetActive(false);
        
    }
    
    void Update() 
    {
        CountEnemy();
        EnlargeComplexity();
        _damage = PlayerPrefs.GetInt("damag");
        PlayerPrefs.SetInt("damag", _damage);
        _count = PlayerPrefs.GetInt("count");
        count = _count;
    }

    IEnumerator SpawnEnemy()
    {
        while (_count != 10)
        {
            if (PlayerPrefs.GetInt("spawn") == 0)
            {
                _count++;
                PlayerPrefs.SetInt("count", _count);

                _enemy = Instantiate(enemyPrefab) as GameObject;

                float angleX = Random.Range(angleXmin, angleXmax);
                float angleZ = Random.Range(angleZmin, angleZmax);

                _enemy.transform.position = new Vector3(angleX, -0.6f, angleZ);
            
                _sec = Random.Range(minSec, maxSec);
                _enemy.transform.SetParent(Spawn.transform);

                yield return new WaitForSeconds(_sec);
            }
            else
            {
                _count++;
                PlayerPrefs.SetInt("count", _count);

                _enemy = Instantiate(enemyPrefab) as GameObject;

                float angleX = Random.Range(angleXmin, angleXmax);
                float angleZ = Random.Range(angleZmin, angleZmax);

                _enemy.transform.position = new Vector3(angleX, -0.6f, angleZ);
            
                _sec = PlayerPrefs.GetInt("spawn");
                _enemy.transform.SetParent(Spawn.transform);

                yield return new WaitForSeconds(_sec);
                PlayerPrefs.SetInt("spawn", 0);
            }
        }
    }

    public void EnlargeComplexity()
    {
        if (levelCount < 10)
        {
            _minSec = 1.0f;
            _maxSec = 5.0f;
            minSec = _minSec;
            maxSec = _maxSec;
            _damage = 100;
            lev = true;
            PlayerPrefs.SetInt("damag", _damage);
            _damage = PlayerPrefs.GetInt("damag");
        }
        else if (levelCount < 15)
        {
            _minSec = 1.0f;
            _maxSec = 4.5f;
            minSec = _minSec;
            maxSec = _maxSec;
            _damage = 50;
            lev = true;
            PlayerPrefs.SetInt("damag", _damage);
            _damage = PlayerPrefs.GetInt("damag");
        }
        else if (levelCount < 20)
        {
            but.SetActive(true);
            _minSec = 1.0f;
            _maxSec = 3.5f;
            minSec = _minSec;
            maxSec = _maxSec;
            _damage = 40;
            lev = true;
            PlayerPrefs.SetInt("damag", _damage);
            _damage = PlayerPrefs.GetInt("damag");
        }
        else if (levelCount < 25)
        {
            _minSec = 1.0f;
            _maxSec = 2.5f;
            spawnSec.SetActive(true);
            minSec = _minSec;
            maxSec = _maxSec;
            _damage = 24;
            lev = true;
            PlayerPrefs.SetInt("damag", _damage);
            _damage = PlayerPrefs.GetInt("damag");
        }
        else if (levelCount < 30)
        {
            _minSec = 1.0f;
            _maxSec = 1.5f;
            minSec = _minSec;
            maxSec = _maxSec;
            _damage = 35;
            lev = true;
            PlayerPrefs.SetInt("damag", _damage);
            _damage = PlayerPrefs.GetInt("damag");
        }
        else if (levelCount < 35)
        {
            _minSec = 0.95f;
            _maxSec = 1.35f;
            minSec = _minSec;
            maxSec = _maxSec;
            _damage = 22;
            lev = true;
            PlayerPrefs.SetInt("damag", _damage);
            _damage = PlayerPrefs.GetInt("damag");
        }
        else if (levelCount < 40)
        {
            _minSec = 0.85f;
            _maxSec = 1.0f;
            minSec = _minSec;
            maxSec = _maxSec;
            _damage = 20;
            lev = true;
            PlayerPrefs.SetInt("damag", _damage);
            _damage = PlayerPrefs.GetInt("damag");
        }
        else if (levelCount < 45)
        {
            _minSec = 0.8f;
            _maxSec = 1.0f;
            minSec = _minSec;
            maxSec = _maxSec;
            _damage = 19;
            lev = true;
            PlayerPrefs.SetInt("damag", _damage);
            _damage = PlayerPrefs.GetInt("damag");
        }
        else if (levelCount < 50)
        {
            _minSec = 0.75f;
            _maxSec = 1.0f;
            minSec = _minSec;
            maxSec = _maxSec;
            _damage = 18;
            lev = true;
            PlayerPrefs.SetInt("damag", _damage);
            _damage = PlayerPrefs.GetInt("damag");
        }
        else if (levelCount < 55)
        {
            _minSec = 0.7f;
            _maxSec = .95f;
            minSec = _minSec;
            maxSec = _maxSec;
            _damage = 17;
            lev = true;
            PlayerPrefs.SetInt("damag", _damage);
            _damage = PlayerPrefs.GetInt("damag");
        }
        else if (levelCount < 60)
        {
            _minSec = 0.65f;
            _maxSec = .9f;
            minSec = _minSec;
            maxSec = _maxSec;
            _damage = 16;
            lev = true;
            PlayerPrefs.SetInt("damag", _damage);
            _damage = PlayerPrefs.GetInt("damag");
        }
    }

    public void CountEnemy()
    {
        if (_count != 10)
        {
            _count = PlayerPrefs.GetInt("count");
            count = _count;
            sec = _sec;
            if (PlayerPrefs.GetInt("dead") == _dead)
            {
                levelCount++;
                PlayerPrefs.SetInt("level", levelCount);
                levelCount = PlayerPrefs.GetInt("level");
                levelText.text = "" + PlayerPrefs.GetInt("level") + "";
                _dead += 1.0f;
                PlayerPrefs.SetFloat("deadCount", _dead);
                PlayerPrefs.SetInt("dead", 0);
                lev = false;
            }
            else if (PlayerPrefs.GetInt("dead") != _dead) 
            {
                if (PlayerPrefs.GetInt("dead") % _dead == 0)
                {
                    bar.fillAmount = 0;
                }
                else
                {
                    if (PlayerPrefs.GetInt("dead") > _dead)
                    {
                        _tmp = PlayerPrefs.GetInt("dead") % (int)_dead;
                        levelCount++;
                        PlayerPrefs.SetInt("level", levelCount);
                        levelCount = PlayerPrefs.GetInt("level");
                        levelText.text = "" + PlayerPrefs.GetInt("level") + "";
                        _dead += 1.0f;
                        PlayerPrefs.SetFloat("deadCount", _dead);
                        PlayerPrefs.SetInt("dead", 0);
                        lev = false;
                        PlayerPrefs.SetInt("dead", _tmp);
                    }
                    if (_tmp < _dead)
                    {
                        float progress = PlayerPrefs.GetInt("dead") / _dead;
                        bar.fillAmount = progress;
                    }
                }
            }
            
        }
        else
        {
            StopCoroutine(SpawnEnemy());
            panelGameOver.SetActive(true);
        }
    }
}
