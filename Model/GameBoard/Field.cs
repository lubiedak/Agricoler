using Model.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.GameBoard
{
    public class Field
    {
        public bool IsEmpty { get; private set; }
        protected List<FieldEvent> FieldEvents { get; set; }

        /// <summary>
        /// Default constructor for Field objects
        /// </summary>
        /// <param name="events">Delegates to events done on specific fields</param>
        public Field(params FieldEvent[] events)
        {
            IsEmpty = false;
            FieldEvents = new List<FieldEvent>();

            foreach (FieldEvent item in events)
                FieldEvents.Add(item);
        }

        /// <summary>
        /// Process actions assigned to the field
        /// </summary>
        /// <param name="p">Player who tooks the action.</param>
        public virtual void ProcessActions(Player p)
        {
            foreach (var action in FieldEvents)
            {
                action(p, null);
            }

            SelectField();
        }

        /// <summary>
        /// Set IsEmpty to true.
        /// </summary>
        protected virtual void SelectField()
        {
            IsEmpty = true;
        }

        /// <summary>
        /// Set IsEmpty to false on every new turn.
        /// </summary>
        public virtual void NextTurn()
        {
            IsEmpty = false;
        }
    }
}
