﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SE104_Library_Manager.Entities;

public class BangCap
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MaBangCap { get; set; }
    public required string TenBangCap { get; set; }
    public bool DaXoa { get; set; } = false;

    public ICollection<NhanVien> DsNhanVien { get; set; } = new List<NhanVien>();
}
