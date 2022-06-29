namespace customExceptions;

// Look up ... PascalCase or camelCase for namepaces


// userName already taken

public class UserNameUnavailable : System.Exception
{
    public UserNameUnavailable() { }
    public UserNameUnavailable(string message) : base(message) { }
    public UserNameUnavailable(string message, System.Exception inner) : base(message, inner) { }
    protected UserNameUnavailable(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}


// login failure

public class InvalidCreds : System.Exception
{
    public InvalidCreds() { }
    public InvalidCreds(string message) : base(message) { }
    public InvalidCreds(string message, System.Exception inner) : base(message, inner) { }
    protected InvalidCreds(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}


// no justification given for reimbursement request