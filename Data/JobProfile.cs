using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Bolsa.Data
{
    public class JobProfile : Base
    {
        public JobProfile() : base()
        {

        }

        public List<Entities.JobProfile> GetAll(int personId)
        {
            List<Entities.JobProfile> jobProfiles = new List<Entities.JobProfile>();

            try
            {
                //"SELECT * FROM JobProfiles jp WHERE jp.Id NOT IN (SELECT JobProfilesId FROM JobProfilePerson WHERE PersonsId = @person)"
                SqlCommand cmd = new SqlCommand("SELECT * FROM JobProfiles jp WHERE jp.Id NOT IN (SELECT JobProfilesId FROM JobProfilePerson WHERE PersonsId = @person)", Conn);
                
                cmd.Parameters.AddWithValue("@person", personId);

                Conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entities.JobProfile jobProfile = new Entities.JobProfile();
                    jobProfile.Id = dr.GetInt32(0);
                    jobProfile.EmailReceptor = dr.GetString(1);
                    jobProfile.StartingDate = dr.GetDateTime(2);
                    jobProfile.EndingDate = dr.GetDateTime(3);
                    jobProfile.Address = dr.GetString(4);
                    jobProfile.Capacity = dr.GetInt32(5);
                    jobProfile.Description = dr.GetString(6);
                    jobProfile.Position = dr.GetString(7);
                    jobProfile.CompanyId = dr.GetInt32(8);
                    jobProfile.CreatedAt = dr.GetDateTime(9);
                    jobProfile.Type = dr.GetString(10);

                    jobProfiles.Add(jobProfile);
                }

                dr.Close();
                Conn.Close();

                return jobProfiles;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Entities.JobProfile GetOne(int personId, int jobProfileId)
        {
            List<Entities.JobProfile> jobProfiles = GetAll(personId);

            Entities.JobProfile jobProfile = jobProfiles.FirstOrDefault(u => u.Id.Equals(jobProfileId));

            return jobProfile;
        }

    }
}
