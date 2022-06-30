namespace Services;

using Models;
using DataStorage;
// using DataAccess;
// using customExceptions;



public class UserService
{
    public void Register(Ticket ticketToRegister)
    {
        TicketStorage.ticketList[TicketStorage.ticketListSize] = ticketToRegister;
        TicketStorage.ticketListSize++;
    } 

}


