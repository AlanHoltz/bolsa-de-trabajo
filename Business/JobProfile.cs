using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Business
{
    public class JobProfile
    {
        public static List<Entities.JobProfile> GetAll()
        {
            return Data.JobProfile.GetAll();
        }

        public static void Insert(Entities.JobProfile jobProfile)
        {
            Data.JobProfile.Insert(jobProfile);
        }
        public static void Update(Entities.JobProfile jobProfile)
        {
            Data.JobProfile.Update(jobProfile);
        }
        public static void Delete(Entities.JobProfile jobProfile)
        {
            Data.JobProfile.Delete(jobProfile);
        }
    }
}
