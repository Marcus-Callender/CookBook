using System;
using System.Collections.Generic;
using UnityEngine;

namespace CoohBooh
{
    public class MenuManager : MonoBehaviour
    {
        public static MenuManager m_instance;

        [SerializeField]
        private List<MenuBase> m_menuPrefabs;

        [SerializeField]
        private List<MenuBase> m_menuStack;

        void Awake()
        {
            if (m_instance == null)
                m_instance = this;
            else
                Debug.LogError("MenuManager instance already existed!");
        }

        void Update()
        {

        }

        public void AddToMenuStack(MenuBase menuType)
        {

        }

        public void OverideMenuStack(MenuBase menuType)
        {
            m_menuStack.Clear();
            m_menuStack.Add(menuType);
        }
    }
}
