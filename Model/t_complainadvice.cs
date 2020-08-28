using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_complainadvice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_complainadvice
	{
		public t_complainadvice()
		{}
		#region Model
		private DateTime? _comd_date;
		private int _comd_id;
		private int? _comd_u_id;
		private int? _comd_staff_id;
		private string _comd_content;
		private string _comd_valid;
		/// <summary>
		/// 
		/// </summary>
		public DateTime? comd_date
		{
			set{ _comd_date=value;}
			get{return _comd_date;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int comd_ID
		{
			set{ _comd_id=value;}
			get{return _comd_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? comd_u_id
		{
			set{ _comd_u_id=value;}
			get{return _comd_u_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? comd_staff_id
		{
			set{ _comd_staff_id=value;}
			get{return _comd_staff_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string comd_content
		{
			set{ _comd_content=value;}
			get{return _comd_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string comd_valid
		{
			set{ _comd_valid=value;}
			get{return _comd_valid;}
		}
		#endregion Model

	}
}

