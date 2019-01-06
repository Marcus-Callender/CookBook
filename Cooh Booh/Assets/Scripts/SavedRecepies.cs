using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace CoohBooh
{
    public class SavedRecepies : MonoBehaviour
    {
        [SerializeField]
        public Recepie[] m_recepies;

        private void Awake()
        {
            if (SaveLoadData.m_instance.m_recepies == null)
            {
                SaveLoadData.m_instance.m_recepies = this;
            }
            else
            {
                Debug.LogError("SaveLoadData already has a refrence to saved recepies");
            }
        }

        // thanks Ignis
        public void AddNewRecepie(Recepie newRecepie)
        {

        }

        public void RemoveRecepie(int recepieID)
        {
            
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
