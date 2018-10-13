using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AddNewRecepie : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private GameObject m_recepiePrefab;

    [SerializeField]
    private GameObject m_locationToAdd;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(gameObject.name + " Was Clicked.");

        GameObject newRecepie = Instantiate(m_recepiePrefab, m_locationToAdd.transform);

        newRecepie.transform.SetSiblingIndex(newRecepie.transform.GetSiblingIndex() - 1);
    }
}
