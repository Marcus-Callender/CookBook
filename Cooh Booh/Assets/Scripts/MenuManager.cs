using System;
using System.Collections.Generic;
using UnityEngine;

namespace CoohBooh
{
    public enum MENU_TYPE
    {
        HOME,
        COOK_BOOK,
        CALENDAR,
        SHOPING_LIST,
        CREATE_MENU,
        NULL
    }

    public class MenuManager : MonoBehaviour
    {
        public static MenuManager m_instance;

        [SerializeField]
        private MenuBase[] m_menuPrefabs;

        [SerializeField]
        private List<MenuBase> m_menuStack;

        private MenuBase currentMenu { get { return m_menuStack[m_menuStack.Count - 1]; } }

        void Awake()
        {
            if (m_instance == null)
                m_instance = this;
            else
                Debug.LogError("MenuManager instance already existed!");

            m_menuPrefabs = new MenuBase[(int)MENU_TYPE.NULL];
        }

        private void Start()
        {
            SaveLoadData.m_instance.LoadData();
        }
        
        public void AddToMenuStack(MenuBase menu)
        {
            currentMenu.OnBecomeInactive();

            currentMenu.gameObject.SetActive(false);

            m_menuStack.Add(menu);

            currentMenu.gameObject.SetActive(true);

            currentMenu.OnBecomeActive();
        }

        public void OverideMenuStack(MenuBase menu)
        {
            currentMenu.OnBecomeInactive();

            currentMenu.gameObject.SetActive(false);

            m_menuStack.Clear();
            m_menuStack.Add(menu);

            currentMenu.gameObject.SetActive(true);

            currentMenu.OnBecomeActive();
        }

        public void PopMenuStack()
        {
            currentMenu.OnBecomeInactive();

            currentMenu.gameObject.SetActive(false);

            m_menuStack.RemoveAt(m_menuStack.Count - 1);

            currentMenu.gameObject.SetActive(true);

            currentMenu.OnBecomeActive();
        }
    }
}
