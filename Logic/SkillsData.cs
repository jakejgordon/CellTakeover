﻿namespace Logic
{
    public class SkillsData
    {
        public SkillsData(float mutationPercentageChancePerAttributePoint,
            float cornerGrowthChancePerAttributePoint,
            float reducedApoptosisPercentagePerAttributePoint,
            float regenerationChancePerAttributePoint,
            float mycotoxinFungicideChancePerAttributePoint, 
            float moistureGrowthBoostPerAttributePoint)
        {
            MutationPercentageChancePerAttributePoint = mutationPercentageChancePerAttributePoint;
            CornerGrowthChancePerAttributePoint = cornerGrowthChancePerAttributePoint;
            ReducedApoptosisPercentagePerAttributePoint = reducedApoptosisPercentagePerAttributePoint;
            RegenerationChancePerAttributePoint = regenerationChancePerAttributePoint;
            MycotoxinFungicideChancePerAttributePoint = mycotoxinFungicideChancePerAttributePoint;
            MoistureGrowthBoostPerAttributePoint = moistureGrowthBoostPerAttributePoint;
        }
       
        public float MutationPercentageChancePerAttributePoint { get; }
        public float CornerGrowthChancePerAttributePoint { get; }
        public float ReducedApoptosisPercentagePerAttributePoint { get; }
        public float RegenerationChancePerAttributePoint { get; }
        public float MycotoxinFungicideChancePerAttributePoint { get; }
        public float MoistureGrowthBoostPerAttributePoint { get; }


        public string IncreaseMutationChanceMessage =>
            $"Increase chance of earning bonus mutation points by {MutationPercentageChancePerAttributePoint}%.";
        public string IncreaseCornerGrowthChanceMessage =>
            $"Increase of corner growth by {CornerGrowthChancePerAttributePoint}%.";

        public string DecreaseApoptosisChanceMessage =>
            $"Decrease chance of random cell death (apoptosis) by {ReducedApoptosisPercentagePerAttributePoint}%.";

        public string IncreaseRegrowthChanceMessage => 
            $"Increase chance of reviving adjacent dead cell by {RegenerationChancePerAttributePoint}%.";

        public string IncreaseMycotoxinFungicideChanceMessage =>
            $"Increase chance of killing an adjacent enemy cell by {MycotoxinFungicideChancePerAttributePoint}%.";

        public string IncreaseMoistureGrowthBoostMessage =>
            $"Place {WaterDropletsPerHydrophiliaPoint} drops of moisture and increase chance of growing into moist regions by {MoistureGrowthBoostPerAttributePoint}%.";

        //TODO make this come from the API
        public static int WaterDropletsPerHydrophiliaPoint = 3;
    }
}