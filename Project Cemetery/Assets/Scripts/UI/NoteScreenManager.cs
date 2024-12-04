using TMPro;
using UnityEngine;

public class NoteScreenManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private TextMeshProUGUI noteText;

    public void SetNoteText(string text)
    {
        noteText.text = text;
    }
}
