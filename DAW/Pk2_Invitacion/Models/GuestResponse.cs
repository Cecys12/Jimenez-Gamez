using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Pk2_Invitacion.Models
{
        
    public class GuestResponse
    {
        [Required(ErrorMessage = "Porfavor ingrese su nombre.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Porfavor ingrese su correo electronico.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Favor de ingresa un CE")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Porfavor ingrese su numero de telefono.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Porfavor ingrese su descicion.")]
        public Boolean? WillAttend { get; set; }

       

        
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
       
    }
}