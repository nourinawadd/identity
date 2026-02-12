using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectedKeywordsDisplay : MonoBehaviour
{
    public Button hairBtn;
    public Button occupationBtn;
    public Button ethnicityBtn;
    public Button facialBtn;

    void Start()
    {
        SetKeywordButton(hairBtn, SearchMemory.hair);
        SetKeywordButton(occupationBtn, SearchMemory.occupation);
        SetKeywordButton(ethnicityBtn, SearchMemory.ethnicity);
        SetKeywordButton(facialBtn, SearchMemory.facial);
    }

    void SetKeywordButton(Button button, string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            button.gameObject.SetActive(false);
        }
        else
        {
            button.gameObject.SetActive(true);

            TMP_Text textField = button.GetComponentInChildren<TMP_Text>();
            textField.text = value;
        }
    }
}
