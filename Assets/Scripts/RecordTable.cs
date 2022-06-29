using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordTable : MonoBehaviour
{
    public Text[] namePayer;
    public Text[] level;
    public Text[] dead;
    public string name1;
    public string name2;
    public int level1;
    public int level2;
    public int dead1;
    public int dead2;
    public int tmp1;

    // void Update()
    // {
    //     SortRecord();
    //     PlayerPrefs.GetString("namePayerSave");
    //     PlayerPrefs.GetInt("levelSave");
    //     PlayerPrefs.GetInt("deadSave");

    //     PlayerPrefs.GetString("namePayerSave0");
    //     PlayerPrefs.GetInt("levelSave0");
    //     PlayerPrefs.GetInt("deadSave0");

    //     PlayerPrefs.GetString("namePayerSave1");
    //     PlayerPrefs.GetInt("levelSave1");
    //     PlayerPrefs.GetInt("deadSave1");

    //     PlayerPrefs.GetString("namePayerSave2");
    //     PlayerPrefs.GetInt("levelSave2");
    //     PlayerPrefs.GetInt("deadSave2");

    //     PlayerPrefs.GetString("namePayerSave3");
    //     PlayerPrefs.GetInt("levelSave3");
    //     PlayerPrefs.GetInt("deadSave3");

    //     PlayerPrefs.GetString("namePayerSave4");
    //     PlayerPrefs.GetInt("levelSave4");
    //     PlayerPrefs.GetInt("deadSave4");

    //     PlayerPrefs.GetString("namePayerSave5");
    //     PlayerPrefs.GetInt("levelSave5");
    //     PlayerPrefs.GetInt("deadSave5");

    //     PlayerPrefs.GetString("namePayerSave6");
    //     PlayerPrefs.GetInt("levelSave6");
    //     PlayerPrefs.GetInt("deadSave6");

    //     PlayerPrefs.GetString("namePayerSave7");
    //     PlayerPrefs.GetInt("levelSave7");
    //     PlayerPrefs.GetInt("deadSave7");

    //     PlayerPrefs.GetString("namePayerSave8");
    //     PlayerPrefs.GetInt("levelSave8");
    //     PlayerPrefs.GetInt("deadSave8");

    //     PlayerPrefs.GetString("namePayerSave9");
    //     PlayerPrefs.GetInt("levelSave9");
    //     PlayerPrefs.GetInt("deadSave9");

    //     PlayerPrefs.GetString("namePayerSave10");
    //     PlayerPrefs.GetInt("levelSave10");
    //     PlayerPrefs.GetInt("deadSave10");

    //     PlayerPrefs.GetString("namePayerSave11");
    //     PlayerPrefs.GetInt("levelSave11");
    //     PlayerPrefs.GetInt("deadSave11");

    //     PlayerPrefs.GetString("namePayerSave12");
    //     PlayerPrefs.GetInt("levelSave12");
    //     PlayerPrefs.GetInt("deadSave12");

    //     PlayerPrefs.GetString("namePayerSave3");
    //     PlayerPrefs.GetInt("levelSave3");
    //     PlayerPrefs.GetInt("deadSave3");
    // }

    // public void Update()
    // {
    //     PlayerPrefs.SetString("namePayer", "Player");
    //     name1 = PlayerPrefs.GetString("namePayer");
    //     level1 = PlayerPrefs.GetInt("level");
    //     dead1 = PlayerPrefs.GetInt("dead");

    //     name2 = PlayerPrefs.SetString("namePayerSave");
    //     level2 = PlayerPrefs.SetInt("levelSave");
    //     dead2 = PlayerPrefs.SetInt("deadSave");
    // }

    public void PrintRecord()
    {
        PlayerPrefs.SetString("namePayer", "Player");
        name1 = PlayerPrefs.GetString("namePayer");
        level1 = PlayerPrefs.GetInt("level");
        dead1 = PlayerPrefs.GetInt("dead");

        // if (level[0].text == "")
        // {
        //     PlayerPrefs.SetString("namePayerSave0", name1);
        //     PlayerPrefs.SetInt("levelSave0", level1);
        //     PlayerPrefs.SetInt("deadSave0", dead1);
        //     level[0].text = "" + PlayerPrefs.GetInt("levelSave0"); + "";
        //     dead[0].text = "" + PlayerPrefs.GetInt("deadSave0"); + "";
        //     namePayer[0].text = "" + PlayerPrefs.GetString("namePayerSave0") + "";
        // }
        // else if (level[0].text != "")
        // {
        //     PlayerPrefs.GetInt("level") > PlayerPrefs.GetInt("levelSave0") ? PlayerPrefs.GetInt("level") : PlayerPrefs.GetInt("levelSave0");
        //     level[1].text = "" + level1 + "";
        //     dead[1].text = "" + dead1 + "";
        //     namePayer[1].text = "" + name1 + "";
        //     level2++;
        // }
        // else if (level[2].text == "" || level2 == 2)
        // {
        //     level[2].text = "" + level1 + "";
        //     dead[2].text = "" + dead1 + "";
        //     namePayer[2].text = "" + name1 + "";
        //     level2++;
        // }
        // else if (level[3].text == "" || level2 == 3)
        // {
        //     level[3].text = "" + level1 + "";
        //     dead[3].text = "" + dead1 + "";
        //     namePayer[3].text = "" + name1 + "";
        //     level2++;
        // }
        // else if (level[4].text == "" || level2 == 4)
        // {
        //     level[4].text = "" + level1 + "";
        //     dead[4].text = "" + dead1 + "";
        //     namePayer[4].text = "" + name1 + "";
        //     level2++;
        // }
        // else if (level[5].text == "" || level2 == 5)
        // {
        //     level[5].text = "" + level1 + "";
        //     dead[5].text = "" + dead1 + "";
        //     namePayer[5].text = "" + name1 + "";
        //     level2++;
        // }
        // else if (level[6].text == "" || level2 == 6)
        // {
        //     level[6].text = "" + level1 + "";
        //     dead[6].text = "" + dead1 + "";
        //     namePayer[6].text = "" + name1 + "";
        //     level2++;
        // }
        // else if (level[7].text == "" || level2 == 7)
        // {
        //     level[7].text = "" + level1 + "";
        //     dead[7].text = "" + dead1 + "";
        //     namePayer[7].text = "" + name1 + "";
        //     level2++;
        // }
        // else if (level[8].text == "" || level2 == 8)
        // {
        //     level[8].text = "" + level1 + "";
        //     dead[8].text = "" + dead1 + "";
        //     namePayer[8].text = "" + name1 + "";
        //     level2++;
        // }
        // else if (level[9].text == "" || level2 == 9)
        // {
        //     level[9].text = "" + level1 + "";
        //     dead[9].text = "" + dead1 + "";
        //     namePayer[9].text = "" + name1 + "";
        //     level2++;
        // }
        // else if (level[10].text == "" || level2 == 10)
        // {
        //     level[10].text = "" + level1 + "";
        //     dead[10].text = "" + dead1 + "";
        //     namePayer[10].text = "" + name1 + "";
        //     level2++;
        // }
        // else if (level[11].text == "" || level2 == 11)
        // {
        //     level[11].text = "" + level1 + "";
        //     dead[11].text = "" + dead1 + "";
        //     namePayer[11].text = "" + name1 + "";
        //     level2++;
        // }
        // else if (level[12].text == "" || level2 == 12)
        // {
        //     level[12].text = "" + level1 + "";
        //     dead[12].text = "" + dead1 + "";
        //     namePayer[12].text = "" + name1 + "";
        //     level2++;
        // }
        // else if (level[13].text == "" || level2 == 13)
        // {
        //     level[13].text = "" + level1 + "";
        //     dead[13].text = "" + dead1 + "";
        //     namePayer[13].text = "" + name1 + "";
        //     level2++;
        // }
        // else
        // {
        //     level[13].text = "" + level1 + "";
        //     dead[13].text = "" + dead1 + "";
        //     namePayer[13].text = "" + name1 + "";
        // }
    }

    public void SortRecord()
    {
        if (dead1 > dead2)
        {
            if (level1 > level2)
            {
                PlayerPrefs.SetString("namePayerSave0", name1);
                PlayerPrefs.SetInt("levelSave0", level1);
                PlayerPrefs.SetInt("deadSave0", dead1);
            }
            else if (level1 <= level2)
            {
                PlayerPrefs.SetString("namePayerSave1", name1);
                PlayerPrefs.SetInt("levelSave1", level1);
                PlayerPrefs.SetInt("deadSave1", dead1);
            }
        }
        else if (dead1 < dead2)
        {
            if (level1 > level2)
            {
                PlayerPrefs.SetString("namePayerSave0", name1);
                PlayerPrefs.SetInt("levelSave0", level1);
                PlayerPrefs.SetInt("deadSave0", dead1);
            }
            else if (level1 <= level2)
            {
                PlayerPrefs.SetString("namePayerSave1", name1);
                PlayerPrefs.SetInt("levelSave1", level1);
                PlayerPrefs.SetInt("deadSave1", dead1);
            }
        }
        if (dead1 == dead2)
        {
            if (level1 > level2)
            {

            }
            else if (level1 == level2)
            {
                
            }
            else if (level1 < level2)
            {
                
            }
        }
    }
}
