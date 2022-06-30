using Models;
using DataAccess;
// using customExceptions;

namespace Services;

public class ticketService
{
    public void Register(Ticket ticketToRegister)
    {
        TicketStorage.ticketList[TicketStorage.ticketListSize] = ticketToRegister;
        TicketStorage.ticketListSize++;
    } 

}


