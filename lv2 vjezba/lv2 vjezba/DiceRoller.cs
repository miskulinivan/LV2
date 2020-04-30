﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv2_vjezba
{
    class DiceRoller
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach(Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(this.resultForEachRoll);
        }
        public int DiceCount
        {
            get { return dice.Count; }
        }
    }
}
