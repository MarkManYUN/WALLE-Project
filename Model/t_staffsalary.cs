using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalleProject.Model
{
    //t_staffsalary
    public class t_staffsalary
    {

        /// <summary>
        /// Sal_ absenteeismDay
        /// </summary>		
        private int _sal_absenteeismday;
        public int Sal_absenteeismDay
        {
            get
            {
                return _sal_absenteeismday;
            }
            set
            {
                _sal_absenteeismday = value;
            }
        }
        /// <summary>
        /// auto_increment
        /// </summary>		
        private int _sal_id;
        public int sal_ID
        {
            get { return _sal_id; }
            set { _sal_id = value; }
        }
        /// <summary>
        /// sal_bonusM
        /// </summary>		
        private decimal _sal_bonusm;
        public decimal sal_bonusM
        {
            get { return _sal_bonusm; }
            set { _sal_bonusm = value; }
        }
        /// <summary>
        /// sal_describe
        /// </summary>		
        private string _sal_describe;
        public string sal_describe
        {
            get { return _sal_describe; }
            set { _sal_describe = value; }
        }
        /// <summary>
        /// sal_deductM
        /// </summary>		
        private decimal _sal_deductm;
        public decimal sal_deductM
        {
            get { return _sal_deductm; }
            set { _sal_deductm = value; }
        }
        /// <summary>
        /// sal_totalM
        /// </summary>		
        private decimal _sal_totalm;
        public decimal sal_totalM
        {
            get { return _sal_totalm; }
            set { _sal_totalm = value; }
        }
        /// <summary>
        /// sal_incrementM
        /// </summary>		
        private decimal _sal_incrementm;
        public decimal sal_incrementM
        {
            get { return _sal_incrementm; }
            set { _sal_incrementm = value; }
        }
        /// <summary>
        /// sal_month
        /// </summary>		
        private int _sal_month;
        public int sal_month
        {
            get { return _sal_month; }
            set { _sal_month = value; }
        }
        /// <summary>
        /// sal_year
        /// </summary>		
        private int _sal_year;
        public int sal_year
        {
            get { return _sal_year; }
            set { _sal_year = value; }
        }
        /// <summary>
        /// sal_date
        /// </summary>		
        private DateTime _sal_date;
        public DateTime sal_date
        {
            get { return _sal_date; }
            set { _sal_date = value; }
        }
        /// <summary>
        /// sal_sta_id
        /// </summary>		
        private int _sal_sta_id;
        public int sal_sta_id
        {
            get { return _sal_sta_id; }
            set { _sal_sta_id = value; }
        }
        /// <summary>
        /// Sal_leaveDay
        /// </summary>		
        private int _sal_leaveday;
        public int Sal_leaveDay
        {
            get { return _sal_leaveday; }
            set { _sal_leaveday = value; }
        }

    }
}
