using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model2.Interfaces;
using Model2.Delegates;

namespace Model2.GameBoard
{
    public class CountableField : Field, ICountable
    {
        private int _quantityToAdd;
        public int Quantity { get; private set; }

        /// <summary>
        /// Default constructor for CountableField objects
        /// </summary>
        /// <param name="startQuantity">Quantity of resources added every turn.</param>
        /// <param name="events">Delegates to events done on specific fields</param>
        public CountableField(int startQuantity, params FieldEvent[] events)
            : base(events)
        {
            Quantity = _quantityToAdd = startQuantity;
        }

        /// <summary>
        /// For every action assigned to Field execute it.
        /// </summary>
        /// <param name="p">Player who's turn is</param>
        public override void ProcessActions(Player p)
        {
            foreach (var action in FieldEvents)
            {
                action(p, Quantity);
            }

            SelectField();
        }

        /// <summary>
        /// Set quantity to zero and IsEmpty to true.
        /// </summary>
        protected override void SelectField()
        {
            Quantity = 0;
            base.SelectField();
        }

        /// <summary>
        /// Update on every next turn.
        /// </summary>
        public override void NextTurn()
        {
            Quantity = _quantityToAdd;
            base.NextTurn();
        }
    }
}
