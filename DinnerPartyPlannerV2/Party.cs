﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyPlannerV2
{
    public class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople;
        public bool FancyDecorations;
        public virtual decimal Cost
        {
            get
            {
                decimal cost = NumberOfPeople * CostOfFoodPerPerson;
                return cost + CostOfDecorations();
            }
        }
        public Party(int numberOfPeople, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            fancyDecorations = FancyDecorations;
        }
        private decimal CostOfDecorations()
        {
            decimal decorationCost;
            if (FancyDecorations)
                return decorationCost = (NumberOfPeople * 15M) + 50M;
            else
                return decorationCost = (NumberOfPeople * 7.5M) + 30M;

        }
    }
    public class DinnerParty : Party
    {
        public bool HealthyOption;
        public override decimal Cost
        {
            get
            {
                decimal cost = base.Cost;
                cost = CalculateBeveragesCost();
                if (HealthyOption)
                {
                    cost *= 0.95M;
                }
                return cost;
            }
        }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption) : base(numberOfPeople, fancyDecorations)
        {
            HealthyOption = healthyOption;
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
        }
        private decimal CalculateBeveragesCost()
        {
            decimal cost;
            if (HealthyOption)

                return cost = (base.NumberOfPeople * 5M);
            else
                return cost = (base.NumberOfPeople * 20M);
        }
    }
    public class BirthDayParty : Party
    {
        public string CakeWriting;
        public bool CakeWritingToLong;
        public int MaxLengthWriting;
        public int WritingLength 
        { 
            get {
                if (WritingLength > MaxLengthWriting) return MaxLengthWriting;
                else return WritingLength;
                    }
        }
        public override decimal Cost
        {
            get
            {
                decimal cost = base.Cost;
                if (CakeSize() == 20) cost += 40M;
                else cost += 75M;
                cost += (WritingLength * 0.25M);
                // dokończyć, napewno brakuje if(NumberOfPeople > 12) cost += 100M;
                return cost;
            }
        }

        private decimal CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 20; // 40zł
            else
                return 40; // 75zł
        }
        private bool CakeToLong()
        {
            if (CakeSize() == 20)
                MaxLengthWriting = 16;
            else
                MaxLengthWriting = 40;
            if (CakeWriting.Length > MaxLengthWriting)

                return true;
            else
                return false;
        }

        public BirthDayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting) : base(numberOfPeople, fancyDecorations)
        {
            FancyDecorations = fancyDecorations;
            NumberOfPeople = numberOfPeople;
            CakeWriting = cakeWriting;

        }
    }
}
