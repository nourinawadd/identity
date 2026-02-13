using UnityEngine;
using TMPro;

public class CaseFileController : MonoBehaviour
{
    public GameObject closedFile;
    public GameObject openFile;
    public TMP_Text caseText;

    void Start()
    {
        caseText.text = CaseManager.Instance.GetCurrentCase().caseDescription;
    }
    public void OpenFile()
    {
        closedFile.SetActive(false);
        openFile.SetActive(true);
    }

    public void CloseFile()
    {
        closedFile.SetActive(true);
        openFile.SetActive(false);
    }
}
