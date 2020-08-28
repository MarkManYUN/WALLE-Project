using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_wastecategory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_wastecategory
	{
		public t_wastecategory()
		{}
		#region Model
		private string _wasc_name;
		private int _wasc_id;
        private int? _wasc_c_id;
        /// <summary>
        /// 
        /// </summary>
        public string wasc_name
		{
			set{ _wasc_name=value;}
			get{return _wasc_name;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int wasc_ID
		{
			set{ _wasc_id=value;}
			get{return _wasc_id;}
		}
        /// <summary>
		/// 
		/// </summary>
		public int? wasc_c_id
        {
            set { _wasc_c_id = value; }
            get { return _wasc_c_id; }
        }
        #endregion Model

    }
}

