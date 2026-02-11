using UnityEngine;

[CreateAssetMenu(fileName = "NewCelebrity", menuName = "Game/Celebrity")]
public class CelebrityData : ScriptableObject
{
    public string celebrityName;
    public Sprite portrait;

    public string hair;
    public string occupation;
    public string ethnicity;
    public string facial;
}
