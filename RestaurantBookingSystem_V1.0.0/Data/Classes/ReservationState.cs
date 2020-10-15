using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantBookingSystem_V1._0._0.Data
{
    public abstract class ReservationState
    {
        public int Id { get; set; }

        private State StateName { get => StateName; set => ChangeState(State.Available, Input.Pending); }

        public abstract void ChangeState();




        enum State { Available, Booked, InProgress, Cancelled, Complete }
        enum Input { Book, Pending, Cancel, Commence, Finish }

        private State ChangeState(State current, Input input)
        {
            return (current, input) switch
            {

                (State.Available, Input.Book) => State.Booked,
                (State.Booked, Input.Cancel) => State.Cancelled,

                (State.Booked, Input.Commence) => State.InProgress,

                (State.InProgress, Input.Finish) => State.Complete,


                //not sure if need this
                (State.Cancelled, Input.Book) => State.Booked,
                (State.Complete, Input.Book) => State.Booked,

                _ => throw new NotSupportedException("State does not exist")
            };
        }
    }


  
}
