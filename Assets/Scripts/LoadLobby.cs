using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadLobby : MonoBehaviour
{
    AsyncOperation asyncOperation;
    public Image loadBar;
    public Text barTxt;
    public string sceneName;

    private float progress;

    private void Start()
    {
        sceneName = PlayerPrefs.GetString("scene", sceneName);
       
        StartCoroutine(LoadSceneCor());
    }

    private void Update()
    {
        barTxt.text = "Loading: " +  progress * 100f + "%";
    }

    IEnumerator LoadSceneCor()
    {
        yield return new WaitForSeconds(1f);
        asyncOperation = SceneManager.LoadSceneAsync(sceneName);
        while (!asyncOperation.isDone)
        {
            progress = asyncOperation.progress / 0.9f;
            loadBar.fillAmount = progress;
            barTxt.text = "Loading: " +  progress * 100f + "%";
            yield return 0;
        }
    }
}
