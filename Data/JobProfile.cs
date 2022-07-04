using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Data
{
    public class JobProfile
    {
        public static List<Entities.JobProfile> GetAll()
        {
        try 
            { 
                string query = "SELECT * FROM [job_profiles]";
                var jobProfiles = new List<Entities.JobProfile>();
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader != null)
                            {
                                while(reader.Read())
                                {
                                    Entities.JobProfile user = new Entities.JobProfile(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetDateTime(3), reader.GetString(4), reader.GetInt32(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8));
                                    jobProfiles.Add(user);
                                }
                            }
                        }
                    }
                }
                return jobProfiles;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public static void Insert(Entities.JobProfile jobProfile)
        {
            try
            {
                string query = @"INSERT INTO [dbo].[job_profiles]
           ([job_profile_mail_receptor]
           ,[job_profile_starting_date]
           ,[job_profile_ending_date]
           ,[job_profile_address]
           ,[job_profile_capacity]
           ,[job_profile_description_name]
           ,[job_profile_position_name]
           ,[company_id])
     VALUES (@MAIL, @STARTING, @ENDING, @ADDRESS, @CAPACITY, @DESCRIPTION, @POSITION, @COMPANY_ID)";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MAIL", SqlDbType.VarChar).Value = jobProfile.MailReceptor;
                        cmd.Parameters.Add("@STARTING", SqlDbType.DateTime).Value = jobProfile.StartingDate;
                        cmd.Parameters.Add("@ENDING", SqlDbType.DateTime).Value = jobProfile.EndingDate;
                        cmd.Parameters.Add("@ADDRESS", SqlDbType.VarChar).Value = jobProfile.Address;
                        cmd.Parameters.Add("@CAPACITY", SqlDbType.Int).Value = jobProfile.Capacity;
                        cmd.Parameters.Add("@DESCRIPTION", SqlDbType.VarChar).Value = jobProfile.Description;
                        cmd.Parameters.Add("@POSITION", SqlDbType.VarChar).Value = jobProfile.Position;
                        cmd.Parameters.Add("@COMPANY_ID", SqlDbType.Int).Value = jobProfile.CompanyId;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Update(Entities.JobProfile jobProfile)
        {
            try
            {
                string query = @"UPDATE [dbo].[job_profiles]
                               SET[job_profile_mail_receptor] = @MAIL
                                  ,[job_profile_starting_date] = @STARTING
                                  ,[job_profile_ending_date] = @ENDING
                                  ,[job_profile_address] = @ADDRESS
                                  ,[job_profile_capacity] = @CAPACITY
                                  ,[job_profile_description_name] = @DESCRIPTION
                                  ,[job_profile_position_name] = @POSITION
                                  ,[company_id] = @COMPANY_ID
                              WHERE job_profile_id = @ID";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MAIL", SqlDbType.VarChar).Value = jobProfile.MailReceptor;
                        cmd.Parameters.Add("@STARTING", SqlDbType.DateTime).Value = jobProfile.StartingDate;
                        cmd.Parameters.Add("@ENDING", SqlDbType.DateTime).Value = jobProfile.EndingDate;
                        cmd.Parameters.Add("@ADDRESS", SqlDbType.VarChar).Value = jobProfile.Address;
                        cmd.Parameters.Add("@CAPACITY", SqlDbType.Int).Value = jobProfile.Capacity;
                        cmd.Parameters.Add("@DESCRIPTION", SqlDbType.VarChar).Value = jobProfile.Description;
                        cmd.Parameters.Add("@POSITION", SqlDbType.VarChar).Value = jobProfile.Position;
                        cmd.Parameters.Add("@COMPANY_ID", SqlDbType.Int).Value = jobProfile.CompanyId;
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = jobProfile.Id;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void Delete(Entities.JobProfile jobProfile)
        {
            try
            {
                string query = "DELETE [job_profiles] WHERE job_profile_id = @ID";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = jobProfile.Id;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

