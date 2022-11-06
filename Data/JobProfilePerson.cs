using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Bolsa.Data
{
    public class JobProfilePerson : Base
    {
        public JobProfilePerson() : base()
        {

        }

        public List<Entities.JobProfilePerson> GetAll()
        {
            List<Entities.JobProfilePerson> jobProfilesPersons = new List<Entities.JobProfilePerson>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM JobProfilePerson", Conn);


                Conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entities.JobProfilePerson jobProfilePerson = new Entities.JobProfilePerson();
                    jobProfilePerson.Id = dr.GetInt32(0);
                    jobProfilePerson.JobProfilesId = dr.GetInt32(1);
                    jobProfilePerson.PersonsId = dr.GetInt32(2);
                    jobProfilePerson.Status = dr.GetString(4);


                    jobProfilesPersons.Add(jobProfilePerson);
                }

                dr.Close();
                Conn.Close();

                return jobProfilesPersons;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Entities.JobProfilePerson GetOne(int jobProfilesId, int personsId)
        {
            List<Entities.JobProfilePerson> jobProfilesPersons = GetAll();

            Entities.JobProfilePerson jobProfilePerson = jobProfilesPersons.FirstOrDefault(u => u.JobProfilesId == jobProfilesId && u.PersonsId == personsId);

            return jobProfilePerson;
        }

        public void Add(Entities.JobProfilePerson jobProfilePerson)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into JobProfilePerson(JobProfilesId, PersonsId, Observations, Status) OUTPUT Inserted.Id values(@jobprofilesid, @personsid, @observations, @status)", Conn);

                cmd.Parameters.AddWithValue("@jobprofilesid", jobProfilePerson.JobProfilesId);
                cmd.Parameters.AddWithValue("@personsid", jobProfilePerson.PersonsId);
                cmd.Parameters.AddWithValue("@observations", jobProfilePerson.Observations);
                cmd.Parameters.AddWithValue("@status", jobProfilePerson.Status);


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
                SqlCommand cmd = new SqlCommand("DELETE FROM JobProfilePerson WHERE Id = @id", Conn);

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

    }
}
