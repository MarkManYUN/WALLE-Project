using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalleProject.Model
{
    /// <summary>
    /// t_wastesupercate:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class t_wastesupercate
    {
        public t_wastesupercate()
        { }
        #region Model
        private string _wastecc_name;
        private int _wastecc_id;
        /// <summary>
        /// 
        /// </summary>
        public string wastecc_name
        {
            set { _wastecc_name = value; }
            get { return _wastecc_name; }
        }
        /// <summary>
        /// auto_increment
        /// </summary>
        public int wastecc_ID
        {
            set { _wastecc_id = value; }
            get { return _wastecc_id; }
        }
        #endregion Model

    }
}
