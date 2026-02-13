using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VerdictController : MonoBehaviour
{
    public GameObject verdictPanel;

    public TMP_Text nameText;
    public TMP_Text verdictText;
    public Image verdictImage;
    public Animator animator;

    public void ShowVerdict(CelebrityData celeb, bool isGuilty)
    {
        nameText.text = celeb.celebrityName;
        verdictImage.sprite = celeb.portrait;
        verdictText.text = isGuilty ? "GUILTY" : "INNOCENT";
        verdictText.color = isGuilty ? Color.red : Color.green;
        verdictPanel.SetActive(true);
        animator.Play("PosterSlideIn");
    }

}
