﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace ApiClient.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        public int NumberOfHumanPlayers { get; set; }
        public int NumberOfAiPlayers { get; set; }
        public int GridSize { get; set; }
        public string Status { get; set; }
        
        [JsonIgnore]
        public int NumberOfCells => GridSize * GridSize;
        public List<PlayerState> Players { get; set; }
        public GameState StartingGameState { get; set; }
        public Dictionary<string, PlayerStats> StartingPlayerStats { get; set; }
        public List<GrowthCycle> GrowthCycles { get; set; } = new List<GrowthCycle>();
        public int GenerationNumber { get; set; }
        public int RoundNumber { get; set; }
        public int TotalDeadCells { get; set; }
        public int TotalEmptyCells { get; set; }
        public int TotalLiveCells { get; set; }
        public int TotalRegeneratedCells { get; set; }
        public int TotalMoistCells { get; set; }
        public string JoinGamePassword { get; set; }
        public int? EndOfGameCountDown { get; set; }
        public int LightLevel { get; set; }
    }
}
