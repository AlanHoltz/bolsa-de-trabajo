using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Data
{
    public class Internship
    {
        public static List<Entities.Internship> GetAll()
        {
        try 
            { 
                string query = "SELECT * FROM [job_profiles] jp INNER JOIN [internships] r ON job_profile_id = internship_id";
                var internships = new List<Entities.Internship>();
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
                                    Entities.Internship internship = new Entities.Internship(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetDateTime(3), reader.GetString(4), reader.GetInt32(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8), Convert.ToBoolean(reader.GetByte(10)), reader.GetInt32(11), reader.GetDateTime(12));
                                    internships.Add(internship);
                                }
                            }
                        }
                    }
                }
                return internships;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public static void Insert(Entities.Internship internship)
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
                OUTPUT Inserted.job_profile_id
                VALUES (@MAIL, @STARTING, @ENDING, @ADDRESS, @CAPACITY, @DESCRIPTION, @POSITION, @COMPANY_ID)";
                
                string query1 = @"INSERT INTO [dbo].[internships]
                ([internship_id], [internship_agreement], [internship_duration], [internship_starting])
                VALUES (@ID, @AGREE, @DURATION, @STARTING)";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MAIL", SqlDbType.VarChar).Value = internship.MailReceptor;
                        cmd.Parameters.Add("@STARTING", SqlDbType.DateTime).Value = internship.StartingDate;
                        cmd.Parameters.Add("@ENDING", SqlDbType.DateTime).Value = internship.EndingDate;
                        cmd.Parameters.Add("@ADDRESS", SqlDbType.VarChar).Value = internship.Address;
                        cmd.Parameters.Add("@CAPACITY", SqlDbType.Int).Value = internship.Capacity;
                        cmd.Parameters.Add("@DESCRIPTION", SqlDbType.VarChar).Value = internship.Description;
                        cmd.Parameters.Add("@POSITION", SqlDbType.VarChar).Value = internship.Position;
                        cmd.Parameters.Add("@COMPANY_ID", SqlDbType.Int).Value = internship.CompanyId;

                        int id = (int) cmd.ExecuteScalar();
                    
                        using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                        {
                            cmd1.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                            cmd1.Parameters.Add("@AGREE", SqlDbType.TinyInt).Value = internship.Agreement;
                            cmd1.Parameters.Add("@DURATION", SqlDbType.Int).Value = internship.Duration;
                            cmd1.Parameters.Add("@STARTING", SqlDbType.DateTime).Value = internship.Starting;

                            cmd1.ExecuteNonQuery();
                        }
                    }

                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Update(Entities.Internship internship)
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

                string query1 = @"UPDATE [dbo].[internships]
                                SET [internship_agreement] = @AGREE, [internship_duration] = @DURATION, [internship_starting] = @STARTING
                                WHERE internship_id = @ID";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MAIL", SqlDbType.VarChar).Value = internship.MailReceptor;
                        cmd.Parameters.Add("@STARTING", SqlDbType.DateTime).Value = internship.StartingDate;
                        cmd.Parameters.Add("@ENDING", SqlDbType.DateTime).Value = internship.EndingDate;
                        cmd.Parameters.Add("@ADDRESS", SqlDbType.VarChar).Value = internship.Address;
                        cmd.Parameters.Add("@CAPACITY", SqlDbType.Int).Value = internship.Capacity;
                        cmd.Parameters.Add("@DESCRIPTION", SqlDbType.VarChar).Value = internship.Description;
                        cmd.Parameters.Add("@POSITION", SqlDbType.VarChar).Value = internship.Position;
                        cmd.Parameters.Add("@COMPANY_ID", SqlDbType.Int).Value = internship.CompanyId;
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = internship.Id;

                        cmd.ExecuteNonQuery();

                        using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                        {
                            cmd1.Parameters.Add("@AGREE", SqlDbType.TinyInt).Value = internship.Agreement;
                            cmd1.Parameters.Add("@DURATION", SqlDbType.Int).Value = internship.Duration;
                            cmd1.Parameters.Add("@STARTING", SqlDbType.DateTime).Value = internship.Starting;
                            cmd1.Parameters.Add("@ID", SqlDbType.Int).Value = internship.Id;

                            cmd1.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void Delete(Entities.Internship internship)
        {
            try
            {
                string query1 = "DELETE [internships] WHERE internship_id = @ID";
                string query2 = "DELETE [job_profiles] WHERE job_profile_id = @ID";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query1, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = internship.Id;

                        cmd.ExecuteNonQuery();

                        using (SqlCommand cmd1 = new SqlCommand(query2, conn))
                        {
                            cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = internship.Id;

                            cmd1.ExecuteNonQuery();
                        }
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

