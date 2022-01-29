using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

[System.Serializable]
public struct TextType {
    [TextArea(1,10)] public string text;
    public float delay;
    public Color color;
    public bool resetColor;
}

public class TypewriterEffect : MonoBehaviour
{
    public Color defaultColor = Color.white;
    public bool resetAllColors = false;
    public float pauseTime = 1.5f;
    public TextType[] words = new TextType[1];

    private TextType firstWord = new TextType();
    private string currentText = "";
    private string sectionText;
    private string completeText = "";
    private string appendedString;
    private bool charDelay;

    void Start() {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText() {
        // Runs through each module
        for (int x = 0; x < words.Length; x++) {
            sectionText = words[x].text;
            if (sectionText.ToLower() == "pause") {
                yield return new WaitForSeconds(words[x].delay);
                continue;
            }
            // Runs through each letter in text
            for (int i = 0; i <= sectionText.Length; i++) {
                try {
                    if (Char.IsLetter(sectionText[i]) || Char.ToString(sectionText[i]) == " ") {
                        charDelay = false;
                    } else {
                        charDelay = true;
                    }
                }
                catch {}

                if (charDelay) {
                    yield return new WaitForSeconds(0.08f);
                }

                currentText = sectionText.Substring(0, i);

                // Sets color of text
                if (words[x].color == new Color(0, 0, 0, 0)) {
                    currentText = $"<color={defaultColor}>" + currentText + "</color>";
                } else {
                    currentText = $"<color=#{ColorUtility.ToHtmlStringRGBA(words[x].color)}>" + currentText + "</color>";
                }

                GetComponent<Text>().text = completeText + currentText;
                yield return new WaitForSeconds(words[x].delay);
            }
            completeText += currentText;
        }
    }

    void OnValidate() {
        if (gameObject.GetComponent<Text>().text == "New Text") {
            gameObject.GetComponent<Text>().text = "";

            firstWord.text = "Hello World";
            firstWord.delay = 0.05f;
            words[0] = firstWord;
        }

        string textPlaceholder = "";
        for (int i = 0; i < words.Length; i++) {
            if (words[i].text.ToLower() == "pause") {
                words[i].color = new Color(0,0,0,0);
                words[i].delay = pauseTime;
                continue;
            }

            textPlaceholder += words[i].text;

            if (resetAllColors) {
                words[i].color = defaultColor;
            }
            else if (words[i].resetColor) {
                words[i].color = defaultColor;
                words[i].resetColor = false;
            }
            
            if (words[i].color == new Color(0, 0, 0, 0)) {
                textPlaceholder = $"<color={defaultColor}>" + textPlaceholder + "</color>";
                words[i].color = defaultColor;
            } else {
                textPlaceholder = $"<color=#{ColorUtility.ToHtmlStringRGBA(words[i].color)}>" + textPlaceholder + "</color>";
            }
        }

        resetAllColors = false;
        GetComponent<Text>().text = textPlaceholder;
    }


}
