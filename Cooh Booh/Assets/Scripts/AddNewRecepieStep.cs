using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AddNewRecepieStep : MonoBehaviour, IPointerDownHandler
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

        Canvas.ForceUpdateCanvases();
        m_layoutGroup.enabled = false;
        m_layoutGroup.enabled = true;
    }
}
