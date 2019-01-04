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
    }

    class RecepieIngredient
    {
        [SerializeField]
        public string m_stepString;

        [SerializeField]
        public mesurementType m_mesurementType;

        [SerializeField]
        public float m_ammount;
    }

    public class Recepie : MonoBehaviour
    {

        [SerializeField]
        private RecepieStep[] m_recepieSteps;

        [SerializeField]
        private RecepieIngredient[] m_recepieIngredients;

        void Start()
        {

        }

        void Update()
        {

        }
    }
}
