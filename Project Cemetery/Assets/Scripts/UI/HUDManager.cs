using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public static HUDManager Instance;

    [Header("References")]
    [SerializeField] private GameObject MausoleumKeyIcon;
    [SerializeField] private GameObject BoxKeyIcon;

    [Space(10)]
    [SerializeField] private GameObject PickUpItemPrompt;

    public void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        MausoleumKeyIcon.SetActive(false);
        BoxKeyIcon.SetActive(false);

        PickUpItemPrompt.SetActive(false);
    }

    public void ShowMausoleumKey(bool show = true)
    {
        MausoleumKeyIcon?.SetActive(show);
    }

    public void ShowBoxKey(bool show = true)
    {
        BoxKeyIcon?.SetActive(show);
    }

    public void ShowPickUpItemPrompt(bool show = true)
    {
        PickUpItemPrompt?.SetActive(show);
    }

    public void ShowNote(string text)
    {
        Debug.Log(text);
    }
}
