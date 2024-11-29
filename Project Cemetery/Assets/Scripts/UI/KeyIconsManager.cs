using UnityEngine;
using UnityEngine.UI;

public class KeyIconsManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject MausoleumKeyIcon, BoxKeyIcon;

    private void Start()
    {
        MausoleumKeyIcon.SetActive(false);
        BoxKeyIcon.SetActive(false);
    }

    public void ShowMausoleumKey(bool show = true)
    {
        MausoleumKeyIcon?.SetActive(show);
    }

    public void ShowBoxKey(bool show = true)
    {
        BoxKeyIcon?.SetActive(show);
    }
}
