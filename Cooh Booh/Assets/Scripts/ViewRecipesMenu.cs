using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoohBooh
{
    public class ViewRecipesMenu : MenuBase
    {
        [SerializeField]
        public DropDownMenu[] m_dropDownMenus;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public override void OnBecomeInactive()
        {
            for (int z = 0; z < m_dropDownMenus.Length; z++)
            {
                m_dropDownMenus[z].CloseMenu();
            }
        }
    }
}
