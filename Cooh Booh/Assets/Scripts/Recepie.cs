using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoohBooh
{
    enum mesurementType
    {
        NUMBER,
        ML,
        G
    }

    enum mealType
    {
        BREAKFAST,
        LUNCH,
        DINNER,
        DESERT
    }

    [SerializeField]
    class RecepieStep
    {
        [SerializeField]
        public string m_stepString;

        [SerializeField]
        public float m_time;

        public RecepieStep(string stepString, float time)
        {
            m_stepString = stepString;
            m_time = time;
        }
    }

    [System.Serializable]
    class RecepieIngredient
    {
        [SerializeField]
        public string m_ingredientName;

        [SerializeField]
        public mesurementType m_mesurementType;

        [SerializeField]
        public float m_ammount;

        public RecepieIngredient(string ingredientName, mesurementType mesurementType, float ammount)
        {
            m_ingredientName = ingredientName;
            m_mesurementType = mesurementType;
            m_ammount = ammount;
        }
    }
    
    [System.Serializable]
    public class Recepie
    {

        [SerializeField]
        private List<RecepieStep> m_recepieSteps;

        [SerializeField]
        private List<RecepieIngredient> m_recepieIngredients;

        [SerializeField]
        public int recepieID;

        public Recepie()
        {
            m_recepieSteps = new List<RecepieStep>();
            m_recepieIngredients = new List<RecepieIngredient>();
        }

        void Start()
        {

        }

        void Update()
        {

        }

        void AddRecepieStep(string stepString, float time)
        {
            m_recepieSteps.Add(new RecepieStep(stepString, time));
        }

        void AddRecepieIngredient(string ingredientName, mesurementType mesurementType, float ammount)
        {
            m_recepieIngredients.Add(new RecepieIngredient(ingredientName, mesurementType, ammount));
        }
    }
}
