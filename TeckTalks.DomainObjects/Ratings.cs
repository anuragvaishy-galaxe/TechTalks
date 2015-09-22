
namespace TechTalks.DomainObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ComponentModel.DataAnnotations;

    public partial class Ratings : BaseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public Int32 RATING_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public Int32 STAR_RATING { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public Int32 USER_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "")]
        public Int32 POST_ID { get; set; }

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
