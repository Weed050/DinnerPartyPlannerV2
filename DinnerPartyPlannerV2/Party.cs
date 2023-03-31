using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyPlannerV2
{
    internal class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople;
        private bool FancyDecorations { get; set; }
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
                cost = 
                return cost;
            }
        }

        public DinnerParty(int numberOfPeople,bool fancyDecorations,bool healthyOption):base(numberOfPeople,fancyDecorations)
        {
            HealthyOption = healthyOption;
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
}
