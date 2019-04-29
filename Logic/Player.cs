﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI;
using Logic.Annotations;

namespace Logic
{
    public class Player : IPlayer
    {
        private Color _color;
        private string _playerId;
        private GrowthScorecard _growthScorecard;
        private int _liveCells;
        private int _deadCells;

        private string _name;
        private int _regrownCells;
        private int _availableMutationPoints;
        private float _hyperMutationSkillLevel;
        private float _antiApoptosisSkillLevel;
        private float _regenerationSkillLevel;
        private float _buddingSkillLevel;
        private float _mycotoxinsSkillLevel;

        public Player(string name, Color playerCellColor, string playerId,
            bool isHuman)
        {
            Name = name;
            Color = playerCellColor;
            PlayerId = playerId;
            IsHuman = isHuman;
            _growthScorecard = new GrowthScorecard();
        }

        public bool IsHuman { get; }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public int AvailableMutationPoints
        {
            get => _availableMutationPoints;
            set
            {
                if (value == _availableMutationPoints) return;
                _availableMutationPoints = value;
                OnPropertyChanged();
            }
        }

        public Color Color
        {
            get => _color;
            set
            {
                if (value.Equals(_color)) return;
                _color = value;
                OnPropertyChanged();
            }
        }

        public string PlayerId
        {
            get => _playerId;
            set
            {
                if (value == _playerId) return;
                _playerId = value;
                OnPropertyChanged();
            }
        }

        public GrowthScorecard GrowthScorecard
        {
            get => _growthScorecard;
            set
            {
                if (Equals(value, _growthScorecard)) return;
                _growthScorecard = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TopLeftGrowthChance));
                OnPropertyChanged(nameof(TopGrowthChance));
                OnPropertyChanged(nameof(TopRightGrowthChance));
                OnPropertyChanged(nameof(RightGrowthChance));
                OnPropertyChanged(nameof(BottomRightGrowthChance));
                OnPropertyChanged(nameof(BottomGrowthChance));
                OnPropertyChanged(nameof(BottomLeftGrowthChance));
                OnPropertyChanged(nameof(LeftGrowthChance));

                OnPropertyChanged(nameof(ApoptosisChancePercentage));
                OnPropertyChanged(nameof(StarvedCellDeathChancePercentage));
                OnPropertyChanged(nameof(RegenerationChancePercentage));
                OnPropertyChanged(nameof(MutationChancePercentage));
                OnPropertyChanged(nameof(MycotoxinFungicideChancePercentage));
            }
        }

        public float ApoptosisChancePercentage => GrowthScorecard.ApoptosisChancePercentage;
        public float StarvedCellDeathChancePercentage => GrowthScorecard.StarvedCellDeathChancePercentage;
        public float RegenerationChancePercentage => GrowthScorecard.RegenerationChancePercentage;
        public float MutationChancePercentage => GrowthScorecard.MutationChancePercentage;
        public float MycotoxinFungicideChancePercentage => GrowthScorecard.MycotoxinFungicideChancePercentage;


        public float TopLeftGrowthChance => GrowthScorecard.GrowthChanceDictionary[RelativePosition.TopLeft];
        public float TopGrowthChance => GrowthScorecard.GrowthChanceDictionary[RelativePosition.Top];
        public float TopRightGrowthChance => GrowthScorecard.GrowthChanceDictionary[RelativePosition.TopRight];
        public float RightGrowthChance => GrowthScorecard.GrowthChanceDictionary[RelativePosition.Right];
        public float BottomRightGrowthChance => GrowthScorecard.GrowthChanceDictionary[RelativePosition.BottomRight];
        public float BottomGrowthChance => GrowthScorecard.GrowthChanceDictionary[RelativePosition.Bottom];
        public float BottomLeftGrowthChance => GrowthScorecard.GrowthChanceDictionary[RelativePosition.BottomLeft];
        public float LeftGrowthChance => GrowthScorecard.GrowthChanceDictionary[RelativePosition.Left];

        public float HyperMutationSkillLevel
        {
            get => _hyperMutationSkillLevel;
            set
            {
                if (value.Equals(_hyperMutationSkillLevel)) return;
                _hyperMutationSkillLevel = value;
                OnPropertyChanged();
            }
        }

        public float AntiApoptosisSkillLevel
        {
            get => _antiApoptosisSkillLevel;
            set
            {
                if (value.Equals(_antiApoptosisSkillLevel)) return;
                _antiApoptosisSkillLevel = value;
                OnPropertyChanged();
            }
        }

        public float RegenerationSkillLevel
        {
            get => _regenerationSkillLevel;
            set
            {
                if (value.Equals(_regenerationSkillLevel)) return;
                _regenerationSkillLevel = value;
                OnPropertyChanged();
            }
        }

        public float BuddingSkillLevel
        {
            get => _buddingSkillLevel;
            set
            {
                if (value.Equals(_buddingSkillLevel)) return;
                _buddingSkillLevel = value;
                OnPropertyChanged();
            }
        }

        public float MycotoxinsSkillLevel
        {
            get => _mycotoxinsSkillLevel;
            set
            {
                if (value.Equals(_mycotoxinsSkillLevel)) return;
                _mycotoxinsSkillLevel = value;
                OnPropertyChanged();
            }
        }

        public int LiveCells
        {
            get => _liveCells;
            set
            {
                if (value == _liveCells) return;
                _liveCells = value;
                OnPropertyChanged();
            }
        }

        public int DeadCells
        {
            get => _deadCells;
            set
            {
                if (value == _deadCells) return;
                _deadCells = value;
                OnPropertyChanged();
            }
        }

        public int RegrownCells
        {
            get => _regrownCells;
            set
            {
                if (value == _regrownCells) return;
                _regrownCells = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string AddMutationChanceMessage => MutationOptionGenerator.IncreaseMutationChanceMessage;
        public string AddCornerGrowthChanceMessage => MutationOptionGenerator.IncreaseCornerGrowthChanceMessage;
        public string DecreaseApoptosisChanceMessage => MutationOptionGenerator.DecreaseApoptosisChanceMessage;

        public string AddRegrowthChanceMessage => MutationOptionGenerator.IncreaseRegrowthChanceMessage;
        public string AddMycotoxicityChanceMessage => MutationOptionGenerator.IncreaseMycotoxinFungicideChanceMessage;

        public void IncreaseHypermutation()
        {
            GrowthScorecard.MutationChancePercentage += MutationOptionGenerator.AdditionalMutationPercentageChancePerAttributePoint;
            AvailableMutationPoints--;
        }

        public void DecreaseApoptosisChance()
        {
            GrowthScorecard.ApoptosisChancePercentage -= MutationOptionGenerator.ReducedApoptosisPercentagePerAttributePoint;
            AvailableMutationPoints--;
        }

        public void IncreaseBudding()
        {
            GrowthScorecard.GrowthChanceDictionary[RelativePosition.TopLeft] +=
                MutationOptionGenerator.AdditionalCornerGrowthChancePerAttributePoint;
            GrowthScorecard.GrowthChanceDictionary[RelativePosition.TopRight] +=
                MutationOptionGenerator.AdditionalCornerGrowthChancePerAttributePoint;
            GrowthScorecard.GrowthChanceDictionary[RelativePosition.BottomRight] +=
                MutationOptionGenerator.AdditionalCornerGrowthChancePerAttributePoint;
            GrowthScorecard.GrowthChanceDictionary[RelativePosition.BottomLeft] +=
                MutationOptionGenerator.AdditionalCornerGrowthChancePerAttributePoint;

            AvailableMutationPoints--;

            OnPropertyChanged(nameof(TopLeftGrowthChance));
            OnPropertyChanged(nameof(TopRightGrowthChance));
            OnPropertyChanged(nameof(BottomRightGrowthChance));
            OnPropertyChanged(nameof(BottomLeftGrowthChance));
        }

        public void IncreaseRegeneration()
        {
            GrowthScorecard.RegenerationChancePercentage +=
                MutationOptionGenerator.AdditionalRegenerationChancePerAttributePoint;

            AvailableMutationPoints--;
        }

        public void IncreaseMycotoxicity()
        {
            GrowthScorecard.MycotoxinFungicideChancePercentage +=
                MutationOptionGenerator.AdditionalMycotoxinFungicideChancePerAttributePoint;

            AvailableMutationPoints--;
        }

        public bool IsCurrentPlayer(string userName)
        {
            return Name == userName;
        }
    }
}