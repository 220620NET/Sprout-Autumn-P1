namespace DataStorage;

using Models;
// using customExceptions;



// Creates array to hold up to 10 sample, existing Tickets

public static class TicketStorage
{
    public static Ticket[] ticketList {get; set;} = new Ticket[10];

    public static int ticketListSize {get; set;} = 0;
}