using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalleProject.Model
{
    /// <summary>
    /// t_wastesmailcate:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class t_wastesmailcate
    {
        public t_wastesmailcate()
        { }
        #region Model
        private string _wastecate_name;
        private int _wastecate_id;
        private int _wastecate_cid;
        /// <summary>
        /// 
        /// </summary>
        public string wastecate_name
        {
            set { _wastecate_name = value; }
            get { return _wastecate_name; }
        }
        /// <summary>
        /// auto_increment
        /// </summary>
        public int wastecate_id
        {
            set { _wastecate_id = value; }
            get { return _wastecate_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int wastecate_cid
        {
            set { _wastecate_cid = value; }
            get { return _wastecate_cid; }
        }
        #endregion Model

    }
}
