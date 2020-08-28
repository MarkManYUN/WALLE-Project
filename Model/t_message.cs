using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_message:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_message
	{
		public t_message()
		{}
		#region Model
		private int _mess_id;
		private string _mess_content;
		private DateTime? _mess_date;
		private int? _mess_inpotance;
		private string _mess_valid;
		private string _mess_type= "1";
		/// <summary>
		/// auto_increment
		/// </summary>
		public int mess_ID
		{
			set{ _mess_id=value;}
			get{return _mess_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mess_content
		{
			set{ _mess_content=value;}
			get{return _mess_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? mess_date
		{
			set{ _mess_date=value;}
			get{return _mess_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? mess_inpotance
		{
			set{ _mess_inpotance=value;}
			get{return _mess_inpotance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mess_valid
		{
			set{ _mess_valid=value;}
			get{return _mess_valid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mess_type
		{
			set{ _mess_type=value;}
			get{return _mess_type;}
		}
		#endregion Model

	}
}

