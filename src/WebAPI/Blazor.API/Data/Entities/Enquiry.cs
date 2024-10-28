using System;
using System.Collections.Generic;

namespace Blazor.API.Data.Entities;

public partial class Enquiry
{
    public long Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string Message { get; set; }

    public string Ipaddress { get; set; }

    public bool IsRead { get; set; }

    public DateTime? ReadDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }
}
