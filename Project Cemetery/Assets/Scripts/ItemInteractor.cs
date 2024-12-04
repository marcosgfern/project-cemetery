using System;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ItemInteractor : MonoBehaviour
{

    [Tooltip("Tag name for pickable objects")]
    [SerializeField] private string PickableTag;

    public Action<PickableItemInfo> OnPick;

    private Pickable _currentPickableItem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PickableTag))
        {
            _currentPickableItem = other.gameObject.GetComponent<Pickable>();
            HUDManager.Instance.ShowPickUpItemPrompt(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(PickableTag))
        {
            _currentPickableItem = null;
            HUDManager.Instance.ShowPickUpItemPrompt(false);
        }
    }

    public void Interact()
    {
        if (_currentPickableItem != null)
        {
            PickUpItem();
        }
    }

    private void PickUpItem()
    {
        Inventory.Instance.AddItem(_currentPickableItem.ItemInfo);
        Destroy(_currentPickableItem.gameObject);
        HUDManager.Instance.ShowPickUpItemPrompt(false);
    }
}
