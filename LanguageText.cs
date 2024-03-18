using UnityEngine;
using UnityEngine.UI;

public class LanguageText : MonoBehaviour
{
    public int language;
    public string[] text;
    private Text textLine;

    void Start()
    {
        language = PlayerPrefs.GetInt("language", language); //загружаем язык
        textLine = GetComponent<Text>(); //обращаемся к компоненту
        textLine.text = "" + text[language]; //указываем какой текст будет отображаться, в зависимости отвыбранного языка
    }
}