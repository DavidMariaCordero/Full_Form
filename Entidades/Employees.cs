using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Full_Form.Entidades
{
    public class Employees
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Cedula { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
    }
}