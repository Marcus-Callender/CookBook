using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CoohBooh
{
    [System.Serializable]
    public class SavedRecepies
    {
        [SerializeField]
        public List<Recepie> m_recepies;

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

            m_recepies = new List<Recepie>();
        }
        
        public void AddNewRecepie(Recepie newRecepie)
        {
            m_recepies.Add(newRecepie);
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
