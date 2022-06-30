namespace Models;

// using customExceptions;

// TICKETS
    // Create Ticket Class

    // ticket creation
    // ticket review
        // View by Manager
            // View tickets from everyone
                // Filter requests by status
            // View tickets from individual
                // approve
                // Deny

        // View by Employee
            // approval request
            
public class Ticket
{
    public Ticket(
        int ticketID,
        int authorID,
        decimal dollarAmount,
        int resolverID,
        string ticketStatus,
        string description,
        string denialReason
    )
    {
        this.ticketID = ticketID;
        this.authorID = authorID;
        this.dollarAmount = dollarAmount;
        this.resolverID = resolverID;
        this.ticketStatus = ticketStatus;
        this.description = description;
        this.denialReason = denialReason;
    }

    public enum ticketStatuses {
        Pending, 
        Approved,
        Denied
    }

    public int ticketID {get; set;}
    public int authorID {get; set;}
    public decimal dollarAmount {get; set;}
    public int resolverID {get; set;}
    public string ticketStatus {get; set;}
    public string description {get; set;}
    public string denialReason {get; set;}

    // methods for 
        // submitting ticket
        // requesting approval
        // viewing tickets for one user
        // viewing all tickets
        // filtering tickets

}