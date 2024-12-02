using System.ComponentModel;
using UnityEditor;
using UnityEngine;

public class ItemInteractor : MonoBehaviour
{

    [Tooltip("Tag name for pickable objects")]
    [SerializeField] private string PickableTag;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PickableTag))
        {
            Debug.Log("Able to pick up item " + other.gameObject.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(PickableTag))
        {
            Debug.Log("Unable to pick up item " + other.gameObject.name);
        }
    }
}
