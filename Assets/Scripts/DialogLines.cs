using UnityEngine;
using TMPro;
using System;

public class DialogLines : MonoBehaviour
{
    [SerializeField] String[] timelineTextLines;
    [SerializeField] TMP_Text dialogText;

    int currentLine = 0;
    public void NextDialogLine()
    {
        currentLine++;
        dialogText.text=timelineTextLines[currentLine];
    }
}
