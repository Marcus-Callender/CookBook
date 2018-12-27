using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace CoohBooh
{
    public class CallMenuButton : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField]
        private bool m_overideMenuStack = false;

        [SerializeField]
        private MenuBase m_type;
    
        public void OnPointerDown(PointerEventData eventData)
        {
            if (m_type != null)
            {
                if (m_overideMenuStack)
                    MenuManager.m_instance.OverideMenuStack(m_type);
                else
                    MenuManager.m_instance.AddToMenuStack(m_type);
            }
        }
    }
}
