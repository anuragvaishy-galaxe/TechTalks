
namespace TechTalks.DomainObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public partial class Users : BaseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public Int32 USER_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public String LOGIN_NAME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public String DISPLAY_NAME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public String TITLE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public String FIRST_NAME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public String LAST_NAME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public String EMAIL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public Int32? STATUS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public DateTime? LAST_SUCCESS_LOGIN { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public DateTime? LAST_FAIL_LOGIN { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public Int32? TOTAL_FAIL_LOGIN { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public DateTime? CRTE_DT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public String CRTE_BY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public DateTime? UPD_DT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public String UPD_BY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public Boolean? DEL_FLG { get; set; }

    }
}
