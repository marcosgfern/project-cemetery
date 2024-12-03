using System.Diagnostics;
using UnityEngine;

public enum ItemKind
{
    MausoleumKey,
    BoxKey,
    Note
}

[CreateAssetMenu(fileName = "PickableItem", menuName = "Scriptable Objects/PickableItem")]
public class PickableItemInfo : ScriptableObject
{
    [SerializeField] public string Name;

    [SerializeField] public ItemKind Kind;

    [Tooltip("Text only used in note items")]
    [TextArea]
    [SerializeField] public string Text;

}
