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

        // Start is called before the first frame update
        void Start()
        {
            dtfi = new System.Globalization.DateTimeFormatInfo();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public override void OnBecomeActive()
        {
            //localDate = DateTime.Now;
            //DateTime firstDayOfMonth = new DateTime(localDate.Year, localDate.Month, 1);
            //int daysInMonth = System.DateTime.DaysInMonth(localDate.Year, localDate.Month);
            
            //Debug.Log("Date is: " + localDate.Day + "/" + localDate.Month + "/" + localDate.Year);
            //Debug.Log("Time is: " + localDate.Hour + ":" + localDate.Minute + ":" + localDate.Second);
            //Debug.Log("Day of week: " + localDate.DayOfWeek);

            DisplayDate = DateTime.Now;
            UpdateDate();
        }

        private void UpdateDate()
        {
            int daysInMonth = DateTime.DaysInMonth(DisplayDate.Year, DisplayDate.Month);
            DayOfWeek dayOfWeek = new DateTime(DisplayDate.Year, DisplayDate.Month, 1).DayOfWeek;
            
            monthYearText.text = dtfi.GetMonthName(DisplayDate.Month) + " " + DisplayDate.Year;

            for (int z = 0; z < tiles.Length; z++)
            {

                if (z < (int)dayOfWeek)
                {
                    tiles[z].SetDate(-1);
                    tiles[z].SetInactive();
                }
                else if (z < (int)dayOfWeek + daysInMonth)
                {
                    tiles[z].SetDate((z - (int)dayOfWeek) + 1);
                    tiles[z].SetActive();
                }
                else if (z >= (int)dayOfWeek + daysInMonth)
                {
                    tiles[z].SetDate(-1);
                    tiles[z].SetInactive();
                }


                //tiles[z].SetInactive();
            }

            /*for (int z = (int)dayOfWeek; z < (int)dayOfWeek + daysInMonth; z++)
            {
                tiles[z].SetActive();
            }*/
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
