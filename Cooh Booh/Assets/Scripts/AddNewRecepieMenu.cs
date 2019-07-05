using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoohBooh
{
    public class AddNewRecepieMenu : MenuBase
    {
        [SerializeField]
        private Recepie m_recepie;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public override void OnBecomeActive()
        {
            m_recepie = new Recepie();
        }

        public void Save()
        {
            SaveLoadData.m_instance.AddNewRecepie(m_recepie);

            MenuManager.m_instance.PopMenuStack();
        }


    }
}
