using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class DataCleanse
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int Status { get; set; }

    public int? Remarks { get; set; }
}
