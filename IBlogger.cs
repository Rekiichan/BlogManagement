using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogManagement
{
    public interface IBlogger
    {
        int ID { get; set; }

        string? Name { get; set; }

        string? Phone { get; set; }

        DateTime BirthDate { get; set; }

        string? Email { get; set; }

        DateTime RegistrationDate { get; set; }

        string? Gender { get; set; }

        string? Address { get; set; }
    }
}
