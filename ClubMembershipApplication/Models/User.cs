using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Models
{
    public class User
    {
        /* This is a Code First approach for data storage so make the model first and then you create the tables in DB accordingly. 
        There is also Database first approach where you create schema in DB and then create DB in vs code using appropraite command.
        */
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumer { get; set; }

        public string AddressFirstLine { get; set;}

        public string AddressSecondLine { get; set; }

        public string AddressCity { get; set; }

        public string PostCode { get; set; }


    }
}
