using UnityEngine;
using UnityEngine.EventSystems;

public class CategorySwitcher : MonoBehaviour
{
    public GameObject hairPanel;
    public GameObject occupationPanel;
    public GameObject ethnicityPanel;
    public GameObject facialPanel;
    public GameObject dropdownMenu;

    void DisableAll()
    {
        hairPanel.SetActive(false);
        occupationPanel.SetActive(false);
        ethnicityPanel.SetActive(false);
        facialPanel.SetActive(false);
    }

    public void ShowHair()
    {
        DisableAll();
        hairPanel.SetActive(true);
        dropdownMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void ShowOccupation()
    {
        DisableAll();
        occupationPanel.SetActive(true);
        dropdownMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void ShowEthnicity()
    {
        DisableAll();
        ethnicityPanel.SetActive(true);
        dropdownMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void ShowFacial()
    {
        DisableAll();
        facialPanel.SetActive(true);
        dropdownMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
    }
}
