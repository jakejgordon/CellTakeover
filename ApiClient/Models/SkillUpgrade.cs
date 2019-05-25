﻿using System.Collections.Generic;

namespace ApiClient.Models
{
    public class SkillUpgrade
    {
        public int PointsSpent { get; set; }
        public List<int> ActiveCellChanges { get; set; } = new List<int>();
    }
}
