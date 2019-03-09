using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropDownMenu : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private GameObject m_expandedMenu;

    [SerializeField]
    private GameObject m_expandIndicator;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        ToggleMenu();
    }

    public void CloseMenu()
    {
        if (m_expandedMenu.activeSelf)
            ToggleMenu();
    }

    private void ToggleMenu()
    {
        m_expandedMenu.SetActive(!m_expandedMenu.activeSelf);
        m_expandIndicator.transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f), 180.0f);
    }
}
