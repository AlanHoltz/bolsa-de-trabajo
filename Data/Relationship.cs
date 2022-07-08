using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Data
{
    public class Relationship
    {
        public static List<Entities.Relationship> GetAll()
        {
        try 
            { 
                string query = "SELECT * FROM [job_profiles] jp INNER JOIN [relationships] r ON job_profile_id = relationship_id";
                var Relationships = new List<Entities.Relationship>();
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
                                    Entities.Relationship relationship = new Entities.Relationship(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetDateTime(3), reader.GetString(4), reader.GetInt32(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8), reader.GetInt32(9));
                                    Relationships.Add(relationship);
                                }
                            }
                        }
                    }
                }
                return Relationships;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public static void Insert(Entities.Relationship Relationship)
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
                
                string query1 = @"INSERT INTO [dbo].[relationships]
                ([relationship_id], [relationship_workday_time])
                VALUES (@ID, @WORKDAY)";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MAIL", SqlDbType.VarChar).Value = Relationship.MailReceptor;
                        cmd.Parameters.Add("@STARTING", SqlDbType.DateTime).Value = Relationship.StartingDate;
                        cmd.Parameters.Add("@ENDING", SqlDbType.DateTime).Value = Relationship.EndingDate;
                        cmd.Parameters.Add("@ADDRESS", SqlDbType.VarChar).Value = Relationship.Address;
                        cmd.Parameters.Add("@CAPACITY", SqlDbType.Int).Value = Relationship.Capacity;
                        cmd.Parameters.Add("@DESCRIPTION", SqlDbType.VarChar).Value = Relationship.Description;
                        cmd.Parameters.Add("@POSITION", SqlDbType.VarChar).Value = Relationship.Position;
                        cmd.Parameters.Add("@COMPANY_ID", SqlDbType.Int).Value = Relationship.CompanyId;

                        int id = (int) cmd.ExecuteScalar();
                    
                        using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                        {
                            cmd1.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                            cmd1.Parameters.Add("@WORKDAY", SqlDbType.Int).Value = Relationship.WorkdayTime;

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

        public static void Update(Entities.Relationship Relationship)
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

                string query1 = @"UPDATE [dbo].[relationships]
                                SET[relationship_workday_time] = @WORKDAY
                                WHERE relationship_id = @ID";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MAIL", SqlDbType.VarChar).Value = Relationship.MailReceptor;
                        cmd.Parameters.Add("@STARTING", SqlDbType.DateTime).Value = Relationship.StartingDate;
                        cmd.Parameters.Add("@ENDING", SqlDbType.DateTime).Value = Relationship.EndingDate;
                        cmd.Parameters.Add("@ADDRESS", SqlDbType.VarChar).Value = Relationship.Address;
                        cmd.Parameters.Add("@CAPACITY", SqlDbType.Int).Value = Relationship.Capacity;
                        cmd.Parameters.Add("@DESCRIPTION", SqlDbType.VarChar).Value = Relationship.Description;
                        cmd.Parameters.Add("@POSITION", SqlDbType.VarChar).Value = Relationship.Position;
                        cmd.Parameters.Add("@COMPANY_ID", SqlDbType.Int).Value = Relationship.CompanyId;
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Relationship.Id;

                        cmd.ExecuteNonQuery();

                        using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                        {
                            cmd1.Parameters.Add("@WORKDAY", SqlDbType.Int).Value = Relationship.WorkdayTime;
                            cmd1.Parameters.Add("@ID", SqlDbType.Int).Value = Relationship.Id;

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
        public static void Delete(Entities.Relationship Relationship)
        {
            try
            {
                string query1 = "DELETE [relationships] WHERE relationship_id = @ID";
                string query2 = "DELETE [job_profiles] WHERE job_profile_id = @ID";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query1, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Relationship.Id;

                        cmd.ExecuteNonQuery();

                        using (SqlCommand cmd1 = new SqlCommand(query2, conn))
                        {
                            cmd1.Parameters.Add("@ID", SqlDbType.Int).Value = Relationship.Id;

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

