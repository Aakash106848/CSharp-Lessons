using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day2
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }   =  string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string MedicalHistory { get; set; } = string.Empty;
        public string PurposeOfVisit { get; set; } = string.Empty;
        public string InsuranceStatus { get; set; } = string.Empty;
        public string MaritalStatus { get; set; } = string.Empty;
        public DateTime Time { get; set; }
        public string Temperature { get; set; } = string.Empty;
        public override string ToString()
        {
            return $"ID: {this.Id}\n"+$"Name:{Title}{FirstName}{LastName}\n" + $"Address:{Address},City:{City},State:{Region},Country:{Country},zip:{PostalCode}\n"+$"Phone: {Phone}\n"+$"Marital Status: {MaritalStatus}\n"+$"Time of Latest Visit: {Time},\n" + $"Medical History:{MedicalHistory}\n"+ $"Current Body Temperature: {Temperature},\n"+$"Purpose of Visit: {PurposeOfVisit}\n"+$"Insurance Status: {InsuranceStatus}\n";
        }
    }
    internal class TestPerson() 
    { 
        public static void TestOne() 
        {
            Person firstperson = new Person();
            firstperson.Id = 1;
            firstperson.FirstName = "Aakash";
            firstperson.LastName = "";
            firstperson.Title = "B";
            firstperson.Address = "Chennai";
            firstperson.City = "C";
            firstperson.Country = "D";
            firstperson.Phone = "1234567890";
            firstperson.PostalCode = "600000";
            firstperson.Region = "TN";
            firstperson.Title = "Mr.";
            firstperson.MaritalStatus = "Unmarried";
            firstperson.MedicalHistory = "Record Available";
            firstperson.PurposeOfVisit = "Migraine";
            firstperson.InsuranceStatus = "Claimable";
            firstperson.Time = DateTime.Now;
            firstperson.Temperature = "98F";
            string value = firstperson.ToString();
            Console.WriteLine(value);

        }
    }
}
