using GameShardsCore3.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameShardsCore3.Core.LibLanguage.LibLanguageManager;

namespace GameShardsCore3.Date {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [WIP()]
    public static class Utils {

        /// <summary>
        /// Returns how many Mondays/Thuersdays/etc are between StartDate and EndDate
        /// </summary>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        /*public static int GetWeekDaysBetween(DateTime StartDate, DateTime EndDate) {

            if (EndDate < StartDate) {
                throw new ArgumentException(LangManager.GetString("exception_date_wrong_end_before_start", CurrentCulture));
            }

            if (StartDate == null || EndDate == null) {
                throw new ArgumentNullException(LangManager.GetString("exception_argument_null", CurrentCulture));
            }

            double d = (EndDate - StartDate).TotalDays;



        }*/

    }

}
