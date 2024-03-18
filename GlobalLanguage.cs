using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalLanguage : MonoBehaviour
{
    public int language;

    private void Start()
    {
        language = PlayerPrefs.GetInt("language", language);
    }

    public void RussianLanguage()
    {
        language = 0;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene("Shop");
    }

    public void EnglishLanguage()
    {
        language = 1;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene("Shop");
    }
}
