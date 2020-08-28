using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalleProject.Model
{
    //t_salarytaxrate
    public class t_salarytaxrate
    {
        /// <summary>
		/// Sta_threshold
        /// </summary>		
		private decimal _sta_threshold;
        public decimal Sta_threshold
        {
            get { return _sta_threshold; }
            set { _sta_threshold = value; }
        }
        /// <summary>
        /// Str_date
        /// </summary>		
        private DateTime _str_date;
        public DateTime Str_date
        {
            get { return _str_date; }
            set { _str_date = value; }
        }
        /// <summary>
        /// Str_aged
        /// </summary>		
        private decimal _str_aged;
        public decimal Str_aged
        {
            get { return _str_aged; }
            set { _str_aged = value; }
        }
        /// <summary>
        /// auto_increment
        /// </summary>		
        private int _str_id;
        public int Str_ID
        {
            get { return _str_id; }
            set { _str_id = value; }
        }
        /// <summary>
        /// Str_medical
        /// </summary>		
        private decimal _str_medical;
        public decimal Str_medical
        {
            get { return _str_medical; }
            set { _str_medical = value; }
        }
        /// <summary>
        /// Str_unemployment
        /// </summary>		
        private decimal _str_unemployment;
        public decimal Str_unemployment
        {
            get { return _str_unemployment; }
            set { _str_unemployment = value; }
        }
        /// <summary>
        /// Str_housing
        /// </summary>		
        private decimal _str_housing;
        public decimal Str_housing
        {
            get { return _str_housing; }
            set { _str_housing = value; }
        }

        /// <summary>
        /// Sta_ supplement
        /// </summary>		
        private decimal _sta_supplement;
        public decimal Sta_supplement
        {
            get
            {
                return _sta_supplement;
            }
            set
            {
                _sta_supplement = value;
            }
        }
        /// <summary>
        /// Sta_ individualTax
        /// </summary>		
        private decimal _sta_individualtax;
        public decimal Sta_individualTax
        {
            get { return _sta_individualtax; }
            set { _sta_individualtax = value; }
        }

    }
	
}
