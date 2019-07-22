﻿using System;
using System.Collections.Generic;

namespace Mtd.OrderMaker.Web.Data
{
    public partial class MtdLogApproval
    {
        public int Id { get; set; }
        public string MtdStore { get; set; }
        public int Stage { get; set; }
        public string UserId { get; set; }
        public int Result { get; set; }
        public DateTime Timecr { get; set; }

        public virtual MtdStore MtdStoreNavigation { get; set; }
        public virtual MtdApprovalStage StageNavigation { get; set; }
    }
}
