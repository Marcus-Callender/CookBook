﻿using System.Collections;
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

    [System.Serializable]
    class RecepieIngredient
    {
        [SerializeField]
        public string m_ingredientName;

        [SerializeField]
        public mesurementType m_mesurementType;

        [SerializeField]
        public float m_ammount;
    }
    
    [System.Serializable]
    public class Recepie
    {

        [SerializeField]
        private RecepieStep[] m_recepieSteps;

        [SerializeField]
        private RecepieIngredient[] m_recepieIngredients;

        [SerializeField]
        public int recepieID;

        void Start()
        {

        }

        void Update()
        {

        }

        void AddRecepieStep(string stepString, float time)
        {
            m_recepieSteps.add 
        }

        void AddRecepieIngredient(string ingredientName, mesurementType mesurementType, float ammount)
        {

        }
    }
}
