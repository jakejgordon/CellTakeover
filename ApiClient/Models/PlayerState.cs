﻿namespace ApiClient.Models
{
    public class PlayerState
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int MutationPoints { get; set; }
        public int ActionPoints { get; set; }
        public bool Human { get; set; }
        public float TopLeftGrowthChance { get; set; }
        public float TopGrowthChance { get; set; }
        public float TopRightGrowthChance { get; set; }
        public float RightGrowthChance { get; set; }
        public float BottomRightGrowthChance { get; set; }
        public float BottomGrowthChance { get; set; }
        public float BottomLeftGrowthChance { get; set; }
        public float LeftGrowthChance { get; set; }
        public int DeadCells { get; set; }
        public int LiveCells { get; set; }
        public int RegeneratedCells { get; set; }
        public int StolenDeadCells { get; set; }
        public int LostDeadCells { get; set; }
        public int PerishedCells { get; set; }
        public int GrownCells { get; set; }
        public int FungicidalKills { get; set; }
        public int SpentMutationPoints { get; set; }
        public int HyperMutationSkillLevel { get; set; }
        public int AntiApoptosisSkillLevel { get; set; }
        public int RegenerationSkillLevel { get; set; }
        public int BuddingSkillLevel { get; set; }
        public int MycotoxinsSkillLevel { get; set; }
        public int HydrophiliaSkillLevel { get; set; }
        public int SporesSkillLevel { get; set; }
        public float ApoptosisChance { get; set; }
        public float StarvedCellDeathChance { get; set; }
        public float MutationChance { get; set; }
        public float RegenerationChance { get; set; }
        public float MycotoxinFungicideChance { get; set; }
        public float MoistureGrowthBoost { get; set; }
        public float SporesChance { get; set; }
        public string Status { get; set; }
    }
}