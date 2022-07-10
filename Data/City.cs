using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Data
{
    public class City
    {
        public static List<Entities.City> GetAll()
        {
        try 
            { 
                string query = "SELECT * FROM [cities]";
                var cities = new List<Entities.City>();
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
                                    Entities.City citie = new Entities.City(reader.GetString(0), reader.GetString(1), reader.GetInt32(2));
                                    cities.Add(citie);
                                }
                            }
                        }
                    }
                }
                return cities;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public static Entities.City GetOne(String zipCode)
        {
            Entities.City city = new Entities.City();
            try
            {
                string query = "SELECT * FROM [cities] WHERE city_zip_code = @ZIP";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn)) { 
                        cmd.Parameters.Add("@ZIP", SqlDbType.Int).Value = zipCode;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader != null)
                            {
                                reader.Read();
                                city.ZipCode = reader.GetString(0);
                                city.Name = reader.GetString(1);
                                city.ProvinceId = reader.GetInt32(2);
                            }
                            return city;
                        }
                    }
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public static void Insert(Entities.City city)
        {
            try
            {
                string query = @"INSERT INTO [dbo].[cities]
           ([city_zip_code], [city_name], [province_id])
     VALUES (@ZIP_CODE, @NAME, @PROVINCE_ID)";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ZIP_CODE", SqlDbType.VarChar).Value = city.ZipCode;
                        cmd.Parameters.Add("@NAME", SqlDbType.VarChar).Value = city.Name;
                        cmd.Parameters.Add("@PROVINCE_ID", SqlDbType.Int).Value = city.ProvinceId;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Update(Entities.City city)
        {
            try
            {
                string query = @"UPDATE [dbo].[cities]
                               SET [city_name] = @NAME, [province_id] = @PROVINCE_ID
                              WHERE city_zip_code = @ZIP_CODE";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@NAME", SqlDbType.VarChar).Value = city.Name;
                        cmd.Parameters.Add("@PROVINCE_ID", SqlDbType.Int).Value = city.ProvinceId;
                        cmd.Parameters.Add("@ZIP_CODE", SqlDbType.VarChar).Value = city.ZipCode;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void Delete(String zipCode)
        {
            try
            {
                string query = "DELETE [cities] WHERE city_zip_code = @ZIP_CODE";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ZIP_CODE", SqlDbType.VarChar).Value = zipCode;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Save(Entities.City city)
        {
            if (city.State == Bolsa.Entities.BusinessEntity.States.New)
            {
                Insert(city);
            }
            else if (city.State == Bolsa.Entities.BusinessEntity.States.Deleted)
            {
                Delete(city.ZipCode);
            }
            else if (city.State == Bolsa.Entities.BusinessEntity.States.Modified)
            {
                Update(city);
            }
            city.State = Bolsa.Entities.BusinessEntity.States.Unmodified;
        }
    }
}

