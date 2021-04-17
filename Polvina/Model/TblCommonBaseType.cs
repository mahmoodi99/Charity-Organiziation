using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CommonBaseType.Model
{
    [Table("tblCommonBaseType")]
    [Index(nameof(BaseTypeTitle), nameof(BaseTypeCode), Name = "UC_tblcommonBaseType", IsUnique = true)]
    public partial class TblCommonBaseType
    {
        [Key]
        public int CommonBaseTypeId { get; set; }
        [Required]
        [StringLength(800)]
        public string BaseTypeTitle { get; set; }
        [StringLength(3)]
        public string BaseTypeCode { get; set; }
        //public object TblCommonBaseData { get; internal set; }
    }
}
