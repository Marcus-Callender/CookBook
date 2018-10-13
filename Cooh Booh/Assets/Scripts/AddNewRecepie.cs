using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AddNewRecepie : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private GameObject m_recepiePrefab;

    [SerializeField]
    private GameObject m_locationToAdd;

    [SerializeField]
    private LayoutGroup m_layoutGroup;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(gameObject.name + " Was Clicked.");

        GameObject newRecepie = Instantiate(m_recepiePrefab, m_locationToAdd.transform);

        newRecepie.transform.SetSiblingIndex(newRecepie.transform.GetSiblingIndex() - 1);

        Canvas.ForceUpdateCanvases();
        m_layoutGroup.enabled = false;
        m_layoutGroup.enabled = true;
    }
}
