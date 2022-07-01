using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordTable : MonoBehaviour
{
    public Text recordTable;
    public Text[] namePlayer;
    public Text[] levelRecord;
    public Text[] deadRecord;
    public GameObject butTable;
    public string name1;
    public int level0;
    public int dead0;
    public int level1;
    public int dead1;
    public int level2;
    public int dead2;
    public int level3;
    public int dead3;
    public int level4;
    public int dead4;
    public int level5;
    public int dead5;
    public int level6;
    public int dead6;
    public int level7;
    public int dead7;
    public int level8;
    public int dead8;
    public int level9;
    public int dead9;
    public int level10;
    public int dead10;
    public int[,] mas1 = new int[11,2];
    public int tmp0;
    public int tmp1;

    void Start()
    {
        butTable.SetActive(false);
        PlayerPrefs.SetString("name", name1);
        level0 = PlayerPrefs.GetInt("levelRecordSave0");
        dead0 = PlayerPrefs.GetInt("deadRecordSave0");
        level1 = PlayerPrefs.GetInt("levelRecordSave1");
        dead1 = PlayerPrefs.GetInt("deadRecordSave1");
        level2 = PlayerPrefs.GetInt("levelRecordSave2");
        dead2 = PlayerPrefs.GetInt("deadRecordSave2");
        level3 = PlayerPrefs.GetInt("levelRecordSave3");
        dead3 = PlayerPrefs.GetInt("deadRecordSave3");
        level4 = PlayerPrefs.GetInt("levelRecordSave4");
        dead4 = PlayerPrefs.GetInt("deadRecordSave4");
        level5 = PlayerPrefs.GetInt("levelRecordSave5");
        dead5 = PlayerPrefs.GetInt("deadRecordSave5");
        level6 = PlayerPrefs.GetInt("levelRecordSave6");
        dead6 = PlayerPrefs.GetInt("deadRecordSave6");
        level7 = PlayerPrefs.GetInt("levelRecordSave7");
        dead7 = PlayerPrefs.GetInt("deadRecordSave7");
        level8 = PlayerPrefs.GetInt("levelRecordSave8");
        dead8 = PlayerPrefs.GetInt("deadRecordSave8");
        level9 = PlayerPrefs.GetInt("levelRecordSave9");
        dead9 = PlayerPrefs.GetInt("deadRecordSave9");
        mas1[10,0] = level10;
        mas1[10,1] = dead10;
    }

    public void Update()
    {
        for (int i = 0; i < namePlayer.Length; i++)
        {
            namePlayer[i].text = ""+PlayerPrefs.GetString("name")+"";
        }
        if (dead0 == 0)
        {
            level0 =  PlayerPrefs.GetInt("level");
            dead0 = PlayerPrefs.GetInt("deadRecord");
            PlayerPrefs.SetInt("levelRecordSave0",mas1[0,0]);
            PlayerPrefs.SetInt("deadRecordSave0",mas1[0,1]);
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.SetInt("deadRecord", 0);
        }
        else if (dead1 == 0)
        {
            level1 =  PlayerPrefs.GetInt("level");
            dead1 = PlayerPrefs.GetInt("deadRecord");
            PlayerPrefs.SetInt("levelRecordSave1",mas1[1,0]);
            PlayerPrefs.SetInt("deadRecordSave1",mas1[1,1]);
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.SetInt("deadRecord", 0);
        }
        else if (dead2 == 0)
        {
            level2 =  PlayerPrefs.GetInt("level");
            dead2 = PlayerPrefs.GetInt("deadRecord");
            PlayerPrefs.SetInt("levelRecordSave2",mas1[2,0]);
            PlayerPrefs.SetInt("deadRecordSave2",mas1[2,1]);
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.SetInt("deadRecord", 0);
        }
        else if (dead3 == 0)
        {
            level3 =  PlayerPrefs.GetInt("level");
            dead3 = PlayerPrefs.GetInt("deadRecord");
            PlayerPrefs.SetInt("levelRecordSave3",mas1[3,0]);
            PlayerPrefs.SetInt("deadRecordSave3",mas1[3,1]);
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.SetInt("deadRecord", 0);
        }
        else if (dead4 == 0)
        {
            level4 =  PlayerPrefs.GetInt("level");
            dead4 = PlayerPrefs.GetInt("deadRecord");
            PlayerPrefs.SetInt("levelRecordSave4",mas1[4,0]);
            PlayerPrefs.SetInt("deadRecordSave4",mas1[4,1]);
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.SetInt("deadRecord", 0);
        }
        else if (dead5 == 0)
        {
            level5 =  PlayerPrefs.GetInt("level");
            dead5 = PlayerPrefs.GetInt("deadRecord");
            PlayerPrefs.SetInt("levelRecordSave5",mas1[5,0]);
            PlayerPrefs.SetInt("deadRecordSave5",mas1[5,1]);
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.SetInt("deadRecord", 0);
        }
        else if (dead6 == 0)
        {
            level6 =  PlayerPrefs.GetInt("level");
            dead6 = PlayerPrefs.GetInt("deadRecord");
            PlayerPrefs.SetInt("levelRecordSave6",mas1[6,0]);
            PlayerPrefs.SetInt("deadRecordSave6",mas1[6,1]);
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.SetInt("deadRecord", 0);
        }
        else if (dead7 == 0)
        {
            level7 =  PlayerPrefs.GetInt("level");
            dead7 = PlayerPrefs.GetInt("deadRecord");
            PlayerPrefs.SetInt("levelRecordSave7",mas1[7,0]);
            PlayerPrefs.SetInt("deadRecordSave7",mas1[7,1]);
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.SetInt("deadRecord", 0);
        }
        else if (dead8 == 0)
        {
            level8 =  PlayerPrefs.GetInt("level");
            dead8 = PlayerPrefs.GetInt("deadRecord");
            PlayerPrefs.SetInt("levelRecordSave8",mas1[8,0]);
            PlayerPrefs.SetInt("deadRecordSave8",mas1[8,1]);
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.SetInt("deadRecord", 0);
        }
        else if (dead9 == 0)
        {
            level9 =  PlayerPrefs.GetInt("level");
            dead9 = PlayerPrefs.GetInt("deadRecord");
            PlayerPrefs.SetInt("levelRecordSave9",mas1[9,0]);
            PlayerPrefs.SetInt("deadRecordSave9",mas1[9,1]);
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.SetInt("deadRecord", 0);
        }
        else
        {
            level10 =  PlayerPrefs.GetInt("level");
            dead10 = PlayerPrefs.GetInt("deadRecord");
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.SetInt("deadRecord", 0);
        }
        mas1[0,0] = level0;
        mas1[0,1] = dead0;
        mas1[1,0] = level1;
        mas1[1,1] = dead1;
        mas1[2,0] = level2;
        mas1[2,1] = dead2;
        mas1[3,0] = level3;
        mas1[3,1] = dead3;
        mas1[4,0] = level4;
        mas1[4,1] = dead4;
        mas1[5,0] = level5;
        mas1[5,1] = dead5;
        mas1[6,0] = level6;
        mas1[6,1] = dead6;
        mas1[7,0] = level7;
        mas1[7,1] = dead7;
        mas1[8,0] = level8;
        mas1[8,1] = dead8;
        mas1[9,0] = level9;
        mas1[9,1] = dead9;
        mas1[10,0] = level10;
        mas1[10,1] = dead10;
        
        for (int i = 0; i < mas1.Length; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                for (int k = i+1; k < 11; k++)
                {
                    if (mas1[j,1] < mas1[k,1])
                    {
                        tmp0 = mas1[j,0];
                        tmp1 = mas1[j,1];
                            
                        mas1[j,0] = mas1[k,0];
                        mas1[j,1] =  mas1[k,1];
                        
                        mas1[k,0] = tmp0;
                        mas1[k,1] =  tmp1;
                        

                        level0 = mas1[0,0];
                        dead0 = mas1[0,1];
                        level1 = mas1[1,0];
                        dead1 = mas1[1,1];
                        level2 = mas1[2,0];
                        dead2 = mas1[2,1];
                        level3 = mas1[3,0];
                        dead3 = mas1[3,1];
                        level4 = mas1[4,0];
                        dead4 = mas1[4,1];
                        level5 = mas1[5,0];
                        dead5 = mas1[5,1];
                        level6 = mas1[6,0];
                        dead6 = mas1[6,1];
                        level7 = mas1[7,0];
                        dead7 = mas1[7,1];
                        level8 = mas1[8,0];
                        dead8 = mas1[8,1];
                        level9 = mas1[9,0];
                        dead9 = mas1[9,1];

                        PlayerPrefs.SetInt("levelRecordSave0",level0);
                        PlayerPrefs.SetInt("deadRecordSave0",dead0);
                        PlayerPrefs.SetInt("levelRecordSave1",level1);
                        PlayerPrefs.SetInt("deadRecordSave1",dead1);
                        PlayerPrefs.SetInt("levelRecordSave2",level2);
                        PlayerPrefs.SetInt("deadRecordSave2",dead2);
                        PlayerPrefs.SetInt("levelRecordSave3",level3);
                        PlayerPrefs.SetInt("deadRecordSave3",dead3);
                        PlayerPrefs.SetInt("levelRecordSave4",level4);
                        PlayerPrefs.SetInt("deadRecordSave4",dead4);
                        PlayerPrefs.SetInt("levelRecordSave5",level5);
                        PlayerPrefs.SetInt("deadRecordSave5",dead5);
                        PlayerPrefs.SetInt("levelRecordSave6",level6);
                        PlayerPrefs.SetInt("deadRecordSave6",dead6);
                        PlayerPrefs.SetInt("levelRecordSave7",level7);
                        PlayerPrefs.SetInt("deadRecordSave7",dead7);
                        PlayerPrefs.SetInt("levelRecordSave8",level8);
                        PlayerPrefs.SetInt("deadRecordSave8",dead8);
                        PlayerPrefs.SetInt("levelRecordSave9",level9);
                        PlayerPrefs.SetInt("deadRecordSave9",dead9);

                        levelRecord[0].text = "" + level0 + "";
                        deadRecord[0].text = "" + dead0 + "";
                        levelRecord[1].text = "" + level1;
                        deadRecord[1].text = "" + dead1 + "";
                        levelRecord[2].text = "" + level2 + "";
                        deadRecord[2].text = "" + dead2 + "";
                        levelRecord[3].text = "" + level3 + "";
                        deadRecord[3].text = "" + dead3 + "";
                        levelRecord[4].text = "" + level4 + "";
                        deadRecord[4].text = "" + dead4 + "";
                        levelRecord[5].text = "" + level5 + "";
                        deadRecord[5].text = "" + dead5 + "";
                        levelRecord[6].text = "" + level6 + "";
                        deadRecord[6].text = "" + dead6 + "";
                        levelRecord[7].text = "" + level7 + "";
                        deadRecord[7].text = "" + dead7 + "";
                        levelRecord[8].text = "" + level8 + "";
                        deadRecord[8].text = "" + dead8 + "";
                        levelRecord[9].text = "" + level9 + "";
                        deadRecord[9].text = "" + dead9 + "";
                    }
                }
            }
                
        }
    }
}