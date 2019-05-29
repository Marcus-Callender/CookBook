using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CoohBooh
{
    public class DateTile : MonoBehaviour
    {
        public Image m_image;
        public Button m_button;
        public Text m_date;
        public Text m_meals;

        private void Awake()
        {
            m_button = GetComponent<Button>();

            m_date = transform.GetChild(0).GetComponent<Text>();
            m_meals = transform.GetChild(1).GetComponent<Text>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SetDate(int date)
        {
            m_date.text = date.ToString();
        }

        public void SetActive()
        {
            m_button.interactable = true;
        }

        public void SetInactive()
        {
            m_button.interactable = false;
        }
    }
}
