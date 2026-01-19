using UnityEngine;

public class TeleportOrb : MonoBehaviour
{
    string tagName; 
    int amountofKillsBeforeUse;

    void Start()
    {
        tagName = "Teleport";
        amountofKillsBeforeUse = 11; 
    }

    public string GetTagName()
    {
        return tagName;
    }


    public int GetAmountofKillsBeforeUse()
    {
        return amountofKillsBeforeUse;
    }
}
