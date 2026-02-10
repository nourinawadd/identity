using UnityEngine;

public class CaseFileController : MonoBehaviour
{
    public GameObject closedFile;
    public GameObject openFile;

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
