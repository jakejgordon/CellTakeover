﻿using System.Collections.Generic;

namespace ApiClient.Models
{
    public class GrowthCycle
    {
        public List<ToastChange> ToastChanges { get; set; }
        public Dictionary<string, int> MutationPointsEarned { get; set; }
        public Dictionary<string, int> ActionPointsEarned { get; set; }
        public int GenerationNumber { get; set; }
        public Dictionary<string, PlayerStatsChanges> PlayerStatsChanges { get; set; }
    }
}