using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CommonBaseData.Model
{
    [Table("tblCommonBaseData")]
    public partial class TblCommonBaseData
    {
        [Key]
        public int CommonBaseDataId { get; set; }
        [StringLength(6)]
        public string BaseCode { get; set; }
        [StringLength(800)]
        public string BaseValue { get; set; }
        public int? CommonBaseTypeId { get; set; }
    }
}
