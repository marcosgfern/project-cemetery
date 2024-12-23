using StarterAssets;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    [Header("References")]
    [SerializeField] private NoteScreenManager noteScreenManager;
    [SerializeField] private StarterAssetsInputs starterAssetsInputs;
    [SerializeField] private FirstPersonController firstPersonController;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        noteScreenManager.gameObject.SetActive(false);
    }

    public void ShowNote(string text)
    {
        noteScreenManager.gameObject.SetActive(true);
        noteScreenManager.SetNoteText(text);

        firstPersonController.MovementEnabled = false;
        starterAssetsInputs.cursorInputForLook = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void CloseNote()
    {
        noteScreenManager.gameObject.SetActive(false);

        firstPersonController.MovementEnabled = true;
        starterAssetsInputs.cursorInputForLook = true;
        Cursor.lockState= CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
