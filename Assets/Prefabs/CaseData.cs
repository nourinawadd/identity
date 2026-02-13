using UnityEngine;

[CreateAssetMenu(fileName = "NewCase", menuName = "Detective/Case")]
public class CaseData : ScriptableObject
{
    [TextArea(5, 15)]
    public string caseDescription;

    public CelebrityData culprit;
}
