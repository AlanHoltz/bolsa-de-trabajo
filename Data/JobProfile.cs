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

        public List<Entities.JobProfile> GetAll()
        {
            List<Entities.JobProfile> jobProfiles = new List<Entities.JobProfile>();

            try
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM JobProfiles WHERE Status = 1", Conn);

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
                    jobProfile.Status = dr.GetBoolean(11);


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


        public List<Entities.JobProfile> GetAll(int personId)
        {
            List<Entities.JobProfile> jobProfiles = new List<Entities.JobProfile>();

            try
            {

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


        public Entities.JobProfile GetOne(int jobProfileId)
        {
            List<Entities.JobProfile> jobProfiles = GetAll();

            Entities.JobProfile jobProfile = jobProfiles.FirstOrDefault(jp => jp.Id.Equals(jobProfileId));

            return jobProfile;
        }

        public void Add(Entities.JobProfile jobProfile)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into JobProfiles(EmailReceptor, StartingDate, EndingDate, Address, Capacity,Description,Position,CompanyId,CreatedAt,Type,Status) VALUES(@receptor, @starting, @ending, @address, @capacity,@description,@position,@companyid,@createdat,@type,@status)", Conn);

                cmd.Parameters.AddWithValue("@receptor", jobProfile.EmailReceptor);
                cmd.Parameters.AddWithValue("@starting", jobProfile.StartingDate);
                cmd.Parameters.AddWithValue("@ending", jobProfile.EndingDate);
                cmd.Parameters.AddWithValue("@address", jobProfile.Address);
                cmd.Parameters.AddWithValue("@capacity", jobProfile.Capacity);
                cmd.Parameters.AddWithValue("@description", jobProfile.Description);
                cmd.Parameters.AddWithValue("@position", jobProfile.Position);
                cmd.Parameters.AddWithValue("@companyid", jobProfile.CompanyId);
                cmd.Parameters.AddWithValue("@createdat", DateTime.Now);
                cmd.Parameters.AddWithValue("@type", jobProfile.Type);
                cmd.Parameters.AddWithValue("@status", true);



                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update JobProfiles set Status = 0 where Id = @id", Conn);

                cmd.Parameters.AddWithValue("@id", id);

                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
        
        public List<Entities.Person> GetApplies(int idProposal)
        {
            List<Entities.Person> persons = new List<Entities.Person>();

            try
            {
                SqlCommand cmd = new SqlCommand("select per.Name, per.Surname, per.BirthDate, u.Mail " +
                "from JobProfiles jp " +
                "inner join JobProfilePerson jpp on jp.Id = jpp.JobProfilesId " +
                "inner join Persons per on jpp.PersonsId = per.Id " +
                "inner join Users u on per.Id = u.Id " +
                "where jp.Id = @id", Conn);

                cmd.Parameters.AddWithValue("@id", idProposal);

                Conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entities.Person person = new Entities.Person();
                    person.Name = dr.GetString(0);
                    person.Surname = dr.GetString(1);
                    person.BirthDate = dr.GetDateTime(2);
                    person.Mail = dr.GetString(3);

                    persons.Add(person);
                }

                dr.Close();
                Conn.Close();

                return persons;
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
