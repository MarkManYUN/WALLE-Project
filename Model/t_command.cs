using System;
namespace WalleProject.Model
{
	/// <summary>
	/// t_command:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_command
	{
		public t_command()
		{}
		#region Model
		private int? _command_user_id;
		private int? _command_staff_id;
		private string _command_content;
		private int _command_id;
		private int? _command_delete=0;
		private int? _command_valid=0;
		private DateTime? _command_date;
		/// <summary>
		/// 
		/// </summary>
		public int? command_user_ID
		{
			set{ _command_user_id=value;}
			get{return _command_user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? command_staff_ID
		{
			set{ _command_staff_id=value;}
			get{return _command_staff_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string command_content
		{
			set{ _command_content=value;}
			get{return _command_content;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int command_ID
		{
			set{ _command_id=value;}
			get{return _command_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? command_Delete
		{
			set{ _command_delete=value;}
			get{return _command_delete;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? command_Valid
		{
			set{ _command_valid=value;}
			get{return _command_valid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? command_Date
		{
			set{ _command_date=value;}
			get{return _command_date;}
		}
		#endregion Model

	}
}

