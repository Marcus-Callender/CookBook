using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CoohBooh
{
    public class CalendarMenu : MenuBase
    {
        [SerializeField]
        private Text monthYearText;

        [SerializeField]
        private DateTile[] tiles;

        private DateTime DisplayDate;

        private System.Globalization.DateTimeFormatInfo dtfi;
        
        void Awake()
        {
            dtfi = new System.Globalization.DateTimeFormatInfo();
        }

        void Update()
        {

        }

        public override void OnBecomeActive()
        {
            DisplayDate = DateTime.Now;
            UpdateDate();
        }

        private void UpdateDate()
        {
            int daysInMonth = DateTime.DaysInMonth(DisplayDate.Year, DisplayDate.Month);
            int daysInPrevMonth = DateTime.DaysInMonth(DisplayDate.Year, DisplayDate.Month - 1);
            DayOfWeek dayOfWeek = new DateTime(DisplayDate.Year, DisplayDate.Month, 1).DayOfWeek;
            
            monthYearText.text = dtfi.GetMonthName(DisplayDate.Month) + " " + DisplayDate.Year;

            for (int z = 0; z < tiles.Length; z++)
            {
                if (z < (int)dayOfWeek)
                {
                    tiles[z].SetDate(daysInPrevMonth + 1 - ((int)dayOfWeek - z));
                    tiles[z].SetInactive();
                }
                else if (z < (int)dayOfWeek + daysInMonth)
                {
                    tiles[z].SetDate((z - (int)dayOfWeek) + 1);
                    tiles[z].SetActive();
                }
                else if (z >= (int)dayOfWeek + daysInMonth)
                {
                    tiles[z].SetDate((z + 1 - (int)dayOfWeek) - daysInMonth);
                    tiles[z].SetInactive();
                }
            }
        }

        public void NextMonth()
        {
            DisplayDate = DisplayDate.AddMonths(1);
            UpdateDate();
        }

        public void PreviousMonth()
        {
            DisplayDate = DisplayDate.AddMonths(-1);
            UpdateDate();
        }
    }
}
