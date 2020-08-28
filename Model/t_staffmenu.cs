using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalleProject.Model
{
    /// <summary>
    /// t_staffmenu:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class t_staffmenu
    {
        public t_staffmenu()
        { }
        #region Model
        private int? _stam_user = 0;
        private int? _stam_boss = 0;
        private int? _stam_admin = 0;
        private int? _stam_staff = 0;
        private string _stam_url;
        private string _stam_name;
        private int _stam_id;
        private int? _stam_delete = 0;
        private int? _stam_menuclass;
        private int? _stam_valid = 1;
        private string StaM_icon= "glyphicon glyphicon-th";

        /// <summary>
        /// 
        /// </summary>
        public int? StaM_Icon
        {
            set { StaM_Icon = value; }
            get { return StaM_Icon; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? StaM_User
        {
            set { _stam_user = value; }
            get { return _stam_user; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? StaM_Boss
        {
            set { _stam_boss = value; }
            get { return _stam_boss; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? StaM_Admin
        {
            set { _stam_admin = value; }
            get { return _stam_admin; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? StaM_Staff
        {
            set { _stam_staff = value; }
            get { return _stam_staff; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StaM_Url
        {
            set { _stam_url = value; }
            get { return _stam_url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StaM_Name
        {
            set { _stam_name = value; }
            get { return _stam_name; }
        }
        /// <summary>
        /// auto_increment
        /// </summary>
        public int StaM_ID
        {
            set { _stam_id = value; }
            get { return _stam_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? StaM_Delete
        {
            set { _stam_delete = value; }
            get { return _stam_delete; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? StaM_MenuClass
        {
            set { _stam_menuclass = value; }
            get { return _stam_menuclass; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? StaM_Valid
        {
            set { _stam_valid = value; }
            get { return _stam_valid; }
        }
        #endregion Model

    }
}
