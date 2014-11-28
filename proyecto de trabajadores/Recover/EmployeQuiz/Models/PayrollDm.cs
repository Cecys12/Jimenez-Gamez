using System;
using System.Collections.Generic;
using System.IO; //Espacio de nombres para lectores de flujo
using System.Linq;
using System.Web;

namespace EmployeQuiz.Models
{
    public class PayrollDm
    {
        //lista de empleados
        List<Employee> empList;

        //constructor del modelo
        public PayrollDm(string dbPath)
        {
            //CREANDO EL OBJETO DE LA LISTA
            empList = new List<Employee>();

            //leer el archivo
            // despues lo parseo

            var reader = new StreamReader(
                File.OpenRead(dbPath));

            //leer y pasear
            while (!reader.EndOfStream)
            {
                //leo una linea
                var line = reader.ReadLine();

                //parsear
                //separar los valores y guardar en un objeto
                var valores = line.Split(',');
                empList.Add(
                    new Employee
                    {
                        Id = valores[0],
                        Name = valores[3],
                        FirstLastname = valores[1],
                        SecondLastname = valores[2],
                        Sex = char.Parse(valores[6]),
                        PhotoPath = valores[7],
                        Wange = double.Parse(valores[5]),
                        Position = valores[4]
                    }
                    );
            }
        }

        //Accesor 
        public Employee GetEmployeedById(string id)
        {
            Employee emp = null;
            foreach (var empladin in empList)
            {
                if (id == empladin.Id)
                {
                    emp = empladin;
                }
            }
            return emp;
        }
    }
}