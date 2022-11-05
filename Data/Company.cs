/* using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Data
{
    public class Company
    {
        public static List<Entities.Company> GetAll()
        {
        try 
            { 
                string query = "SELECT * FROM [users] u INNER JOIN [companies] c ON u.user_id = c.company_id WHERE u.user_status = 1";
                var companies = new List<Entities.Company>();
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
                                    Entities.Company company = new Entities.Company(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), Convert.ToBoolean(reader.GetByte(3)), reader.GetDateTime(4), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), Convert.ToBoolean(reader.GetByte(15)), reader.GetString(16));
                                    companies.Add(company);
                                }
                            }
                        }
                    }
                }
                return companies;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static Entities.Company GetOne(int ID)
        {
            Entities.Company company = new Entities.Company();
            try
            {
                string query = "SELECT * FROM [users] u INNER JOIN [companies] c ON u.user_id = c.company_id WHERE u.user_status = 1 AND c.company_id = @ID";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader != null)
                            {
                                reader.Read();
                                company = new Entities.Company(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), Convert.ToBoolean(reader.GetByte(3)), reader.GetDateTime(4), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), Convert.ToBoolean(reader.GetByte(15)), reader.GetString(16));
                            }
                        }
                    }
                }
                return company;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static void Insert(Entities.Company company)
        {
            try
            {
                string query1 = "INSERT INTO [users] (user_mail, user_password, user_status, user_signup_date) OUTPUT Inserted.user_id VALUES (@EMAIL, @PASSWORD, @STATUS, @FECHAREGISTRO)";
                string query2 = @"INSERT INTO [dbo].[companies]
                                    ([company_id]
                                    ,[company_name]
                                    ,[company_cuit]
                                    ,[company_category]
                                    ,[company_address]
                                    ,[company_city_zip_code]
                                    ,[company_reference_name]
                                    ,[company_reference_phone]
                                    ,[company_reference_email]
                                    ,[company_reference_area]
                                    ,[company_reference_working_on_company]
                                    ,[company_photo])
                                VALUES
                                    (@ID
                                    ,@NAME
                                    ,@CUIT
                                    ,@CATEGORY
                                    ,@ADDRESS
                                    ,@ZIP_CODE
                                    ,@REFER_NAME
                                    ,@REFER_PHONE
                                    ,@REFER_EMAIL
                                    ,@REFER_AREA
                                    ,@REFER_WORK
                                    ,@PHOTO)";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                    {
                        cmd1.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = company.Mail;
                        cmd1.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = company.Password;
                        cmd1.Parameters.Add("@STATUS", SqlDbType.TinyInt).Value = 1;
                        cmd1.Parameters.Add("@FECHAREGISTRO", SqlDbType.Date).Value = DateTime.Now.ToString("dd/MM/yyyy");

                        int id = (int) cmd1.ExecuteScalar();

                        using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                        {
                            cmd2.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                            cmd2.Parameters.Add("@NAME", SqlDbType.VarChar).Value = company.Name;
                            cmd2.Parameters.Add("@CUIT", SqlDbType.VarChar).Value = company.Cuit;
                            cmd2.Parameters.Add("@CATEGORY", SqlDbType.VarChar).Value = company.Category;
                            cmd2.Parameters.Add("@ADDRESS", SqlDbType.VarChar).Value = company.Address;
                            cmd2.Parameters.Add("@ZIP_CODE", SqlDbType.VarChar).Value = company.ZipCode;
                            cmd2.Parameters.Add("@REFER_NAME", SqlDbType.VarChar).Value = company.ReferenceName;
                            cmd2.Parameters.Add("@REFER_PHONE", SqlDbType.VarChar).Value = company.ReferencePhone;
                            cmd2.Parameters.Add("@REFER_EMAIL", SqlDbType.VarChar).Value = company.ReferenceEmail;
                            cmd2.Parameters.Add("@REFER_AREA", SqlDbType.VarChar).Value = company.ReferenceArea;
                            cmd2.Parameters.Add("@REFER_WORK", SqlDbType.TinyInt).Value = company.ReferenceWorkOnCompany;
                            cmd2.Parameters.Add("@PHOTO", SqlDbType.VarChar).Value = company.Photo;

                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void Update(Entities.Company company)
        {
            try
            {
                string query = @"UPDATE [dbo].[companies]
                               SET [company_name] = @NAME
                                  ,[company_cuit] = @CUIT
                                  ,[company_category] = @CATEGORY
                                  ,[company_address] = @ADDRESS
                                  ,[company_city_zip_code] = @ZIP_CODE
                                  ,[company_reference_name] = @REFER_NAME
                                  ,[company_reference_phone] = @REFER_PHONE
                                  ,[company_reference_email] = @REFER_EMAIL
                                  ,[company_reference_area] = @REFER_AREA
                                  ,[company_reference_working_on_company] = @REFER_WORK
                                  ,[company_photo] = @PHOTO
                             WHERE company_id = @ID";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd1 = new SqlCommand(query, conn))
                    {
                        cmd1.Parameters.Add("@NAME", SqlDbType.VarChar).Value = company.Name;
                        cmd1.Parameters.Add("@CUIT", SqlDbType.VarChar).Value = company.Cuit;
                        cmd1.Parameters.Add("@CATEGORY", SqlDbType.VarChar).Value = company.Category;
                        cmd1.Parameters.Add("@ADDRESS", SqlDbType.VarChar).Value = company.Address;
                        cmd1.Parameters.Add("@ZIP_CODE", SqlDbType.VarChar).Value = company.ZipCode;
                        cmd1.Parameters.Add("@REFER_NAME", SqlDbType.VarChar).Value = company.ReferenceName;
                        cmd1.Parameters.Add("@REFER_PHONE", SqlDbType.VarChar).Value = company.ReferencePhone;
                        cmd1.Parameters.Add("@REFER_EMAIL", SqlDbType.VarChar).Value = company.ReferenceEmail;
                        cmd1.Parameters.Add("@REFER_AREA", SqlDbType.VarChar).Value = company.ReferenceArea;
                        cmd1.Parameters.Add("@REFER_WORK", SqlDbType.TinyInt).Value = company.ReferenceWorkOnCompany;
                        cmd1.Parameters.Add("@PHOTO", SqlDbType.VarChar).Value = company.Photo;
                        cmd1.Parameters.Add("@ID", SqlDbType.Int).Value = company.Id;

                        cmd1.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void Delete(Entities.Company company)
        {
            try
            {
                string query1 = "UPDATE [users] SET user_status = @STATUS WHERE user_id = @ID";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                    {
                        cmd1.Parameters.Add("@STATUS", SqlDbType.TinyInt).Value = 0;
                        cmd1.Parameters.Add("@ID", SqlDbType.VarChar).Value = company.Id;

                        cmd1.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void Save(Bolsa.Entities.Company company)
        {
            if (company.State == Bolsa.Entities.BusinessEntity.States.New)
            {
                Insert(company);
            }
            else if (company.State == Bolsa.Entities.BusinessEntity.States.Deleted)
            {
                Delete(company);
            }
            else if (company.State == Bolsa.Entities.BusinessEntity.States.Modified)
            {
                Update(company);
            }
            company.State = Bolsa.Entities.BusinessEntity.States.Unmodified;
        }
    }
}
*/