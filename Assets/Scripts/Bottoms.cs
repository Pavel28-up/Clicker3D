using UnityEngine;
using UnityEngine.SceneManagement;

public class Bottoms : MonoBehaviour
{
    public GameObject panelBut;
    public GameObject recordTable;
    public GameObject panelTitle;
    public string sceneName;


    public void RestartGame()
    {
        sceneName = "Games";
        PlayerPrefs.SetString("scene", sceneName);
        sceneName = PlayerPrefs.GetString("scene");
        SceneManager.LoadScene("LoadLobby");
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("level", 0);
        PlayerPrefs.SetInt("dead", 0);
        PlayerPrefs.SetInt("deadRecord", 0);
        sceneName = "Games";
        PlayerPrefs.SetString("scene", sceneName);
        sceneName = PlayerPrefs.GetString("scene");
        SceneManager.LoadScene("LoadLobby");
    }

    public void Menu()
    {
        sceneName = "Menu";
        PlayerPrefs.SetString("scene", sceneName);
        sceneName = PlayerPrefs.GetString("scene");
        SceneManager.LoadScene("LoadLobby");
    }

    public void OpenRecordTable()
    {
        recordTable.SetActive(true);
        panelBut.SetActive(false);
    }

    public void ClosedRecordTable()
    {
        panelBut.SetActive(true);
        recordTable.SetActive(false);
    }

    public void OpenTitle()
    {
        panelTitle.SetActive(true);
        recordTable.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
