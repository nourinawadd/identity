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
        hairBtn.GetComponentInChildren<TMP_Text>().text = SearchMemory.hair;
        occupationBtn.GetComponentInChildren<TMP_Text>().text = SearchMemory.occupation;
        ethnicityBtn.GetComponentInChildren<TMP_Text>().text = SearchMemory.ethnicity;
        facialBtn.GetComponentInChildren<TMP_Text>().text = SearchMemory.facial;
    }
}
