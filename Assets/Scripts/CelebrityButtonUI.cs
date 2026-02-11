using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CelebrityButtonUI : MonoBehaviour
{
    public Image portraitImage;

    CelebrityData celebData;
    CelebrityInspectorController inspector;

    public void Setup(CelebrityData data,
                      CelebrityInspectorController controller)
    {
        celebData = data;
        inspector = controller;

        portraitImage.sprite = data.portrait;

        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        inspector.ShowCelebrity(celebData);
    }
}
