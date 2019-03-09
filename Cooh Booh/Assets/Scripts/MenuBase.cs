﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoohBooh
{
    public class MenuBase : MonoBehaviour
    {
        public static MENU_TYPE m_menuType = MENU_TYPE.NULL;
        
        public virtual void OnBecomeActive()
        {

        }

        public virtual void OnBecomeInactive()
        {

        }
    }
}
