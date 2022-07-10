using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsa.Entities
{
    public class Company : User
    {
        public Company() : base()
        {

        }
        public Company(int id, String mail, String password, Boolean status, DateTime signupDate, String name, String cuit, String category, String address, String zipCode, String referenceName, String referencePhone, String referenceEmail, String referenceArea, Boolean referenceWorkOnCompany, String photo) : base(mail, password, status, signupDate)
        {
            Id = id;
            Name = name;
            Cuit = cuit;
            Category = category;
            Address = address;
            ZipCode = zipCode;
            ReferenceName = referenceName;
            ReferencePhone = referencePhone;
            ReferenceEmail = referenceEmail;
            ReferenceArea = referenceArea;
            ReferenceWorkOnCompany = ReferenceWorkOnCompany;
            Photo = photo;
        }
        public Company(String mail, String password, Boolean status, DateTime signupDate, String name, String cuit, String category, String address, String zipCode, String referenceName, String referencePhone, String referenceEmail, String referenceArea, Boolean referenceWorkOnCompany, String photo) : base(mail, password, status, signupDate)
        {
            Name = name;
            Cuit = cuit;
            Category = category;
            Address = address;
            ZipCode = zipCode;
            ReferenceName = referenceName;
            ReferencePhone = referencePhone;
            ReferenceEmail = referenceEmail;
            ReferenceArea = referenceArea;
            ReferenceWorkOnCompany = referenceWorkOnCompany;
            Photo = photo;
        }
        public Company(String mail, String password) : base(mail, password)
        {
        }
        public String Name { get; set; }
        public String Cuit { get; set; }
        public String Category { get; set; }
        public String Address { get; set; }
        public String ZipCode { get; set; }
        public String ReferenceName { get; set; }
        public String ReferencePhone { get; set; }
        public String ReferenceEmail { get; set; }
        public String ReferenceArea { get; set; }
        public Boolean ReferenceWorkOnCompany { get; set; }
        public String Photo { get; set; }
    }
}
