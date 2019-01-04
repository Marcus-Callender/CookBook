using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

namespace CoohBooh
{
    public class SaveLoadData : MonoBehaviour
    {
        public static SaveLoadData m_instance = null;

        [SerializeField]
        public /*static*/ SavedRecepies m_recepies = null;
        private /*static*/ string dataPath;

        private void Awake()
        {
            if (m_instance == null)
            {
                m_instance = this;
            }
            else
            {
                Debug.LogError("Instance for SaveLoadData already exists!");
                Destroy(this);
            }
        }

        // Use this for initialization
        void Start()
        {
            dataPath = Path.Combine(Application.persistentDataPath, "CharacterData.txt");
        }

        // Update is called once per frame
        void Update()
        {

        }

        /*static*/ public void SaveData()
        {
            string jsonString = JsonUtility.ToJson(m_recepies);

            using (StreamWriter streamWriter = File.CreateText(dataPath))
            {
                streamWriter.Write(jsonString);
            }
        }

        /*static*/ public void LoadData()
        {
            if (File.Exists(dataPath))
            {
                using (StreamReader streamReader = File.OpenText(dataPath))
                {
                    string jsonString = streamReader.ReadToEnd();
                    m_recepies = JsonUtility.FromJson<SavedRecepies>(jsonString);
                }
            }
            else
            {
                Debug.LogWarning("Save data could not be found, creating new save data.");
                File.Create(dataPath);
                SaveData();
            }
        }
    }
}
