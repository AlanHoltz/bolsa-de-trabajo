using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritorio
{
    public class Session
    {
        public static int? Id = null;
        public static string? Mail = null;
        public static string? Type = null;
        public static string? Name = null;

        public static string? Surname = null;
        public static Boolean? IsAdmin = null;

        public static string? CUIT = null;
        public static string? Status = null;

        public static void Reset()
        {
            Id = null;
            Mail = null;
            Type = null;
            Name = null;
            Surname = null;
            IsAdmin = null;
            CUIT = null;
            Status = null;
        }
    }
}
