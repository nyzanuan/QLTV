namespace Sharing.Model
{
    public enum Gender
    {
        Nam,
        Nữ,


    }
    public enum GenderCheck
    {
        Nam,
        Nu,
        Error

    }


    public enum UserRole
    {
        User,
        Admin,
        Error
    }
    public enum UserRoleCheck
    {
        User,
        Admin,

    }
    public enum BookStatus
    {
        Active,
        Inactive
    }

    public enum LoanAvailability
    {
        Available,
        NotAvailable
    }
    public enum LoanReceiptStatus
    {
        Borrowed,
        Returned,
        Extend,
        Overdue,
        Lost,
    }
}
