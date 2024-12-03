using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    [Tooltip("List of current items own by the player")]
    public List<PickableItemInfo> PickableInventory;

    public void Awake()
    {
        Instance = this;
    }
    
    public void AddItem(PickableItemInfo item)
    {
        PickableInventory.Add(item);

        switch (item.Kind)
        {
            case ItemKind.MausoleumKey:
                HUDManager.Instance.ShowMausoleumKey(true);
                break;
            case ItemKind.BoxKey:
                HUDManager.Instance.ShowBoxKey(true);
                break;
            case ItemKind.Note:
                HUDManager.Instance.ShowNote(item.Text);
                break;
        }
        
    }
}
