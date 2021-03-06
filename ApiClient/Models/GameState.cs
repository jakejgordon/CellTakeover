﻿using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace ApiClient.Models
{
    public class GameState
    {
        private Dictionary<int, FungalCell> _cellDictionary;
        private List<FungalCell> _fungalCells = new List<FungalCell>();

        [JsonIgnore]
        public Dictionary<int, FungalCell> CellsDictionary
        {
            get
            {
                return _cellDictionary ?? (_cellDictionary = FungalCells.ToDictionary(x => x.Index, y => y));
            }
        }

        public List<FungalCell> FungalCells
        {
            get => _fungalCells;
            set
            {
                _fungalCells = value;
                _cellDictionary = null;
            } 
        }
    }
}