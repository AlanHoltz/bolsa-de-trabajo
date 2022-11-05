/* using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Bolsa.Data
{
    public class Province
    {
        public static List<Entities.Province> GetAll()
        {
        try 
            { 
                string query = "SELECT * FROM [provinces]";
                var provinces = new List<Entities.Province>();
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
                                    Entities.Province province = new Entities.Province(reader.GetInt32(0), reader.GetString(1));
                                    provinces.Add(province);
                                }
                            }
                        }
                    }
                }
                return provinces;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public static Entities.Province GetOne(int ID)
        {
            Entities.Province province = new Entities.Province();
            try
            {
                string query = "SELECT * FROM [provinces] WHERE province_id = @ID";
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
                                province.Id = ID;
                                province.Name = reader.GetString(1);

                            }
                        }
                    }
                }
                return province;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public static void Insert(Entities.Province province)
        {
            try
            {
                string query = @"INSERT INTO [dbo].[provinces]
           ([province_name])
     VALUES (@NAME)";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@NAME", SqlDbType.VarChar).Value = province.Name;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Update(Entities.Province province)
        {
            try
            {
                string query = @"UPDATE [dbo].[provinces]
                               SET [province_name] = @NAME
                              WHERE province_id = @ID";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@NAME", SqlDbType.VarChar).Value = province.Name;
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = province.Id;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void Delete(int ID)
        {
            try
            {
                string query = "DELETE [provinces] WHERE province_id = @ID";
                using (SqlConnection conn = Singleton.GetInstance().Open())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Save(Bolsa.Entities.Province province)
        {
            if (province.State == Bolsa.Entities.BusinessEntity.States.New)
            {
                Insert(province);
            }
            else if (province.State == Bolsa.Entities.BusinessEntity.States.Deleted)
            {
                Delete(province.Id);
            }
            else if (province.State == Bolsa.Entities.BusinessEntity.States.Modified)
            {
                Update(province);
            }
            province.State = Bolsa.Entities.BusinessEntity.States.Unmodified;
        }
    }
}

*/