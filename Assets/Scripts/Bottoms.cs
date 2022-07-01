using UnityEngine;
using UnityEngine.SceneManagement;

public class Bottoms : MonoBehaviour
{
    public GameObject panelBut;
    public GameObject recordTable;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Games");
        PlayerPrefs.SetInt("level", 0);
        PlayerPrefs.SetInt("dead", 0);
        PlayerPrefs.SetInt("deadRecord", 0);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
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
}
