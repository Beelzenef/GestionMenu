using System;
using System.Linq;

namespace ConLINQ
{
    class pruebaLINQ
    {
        // Usando WHERE
        string _LastName = "Prescott";
        IQueryable<Employee> emps = from e in Employees
                                    where e.LastName == _LastName
                                    select e;

        // Usando una Clase para capturar los datos
        private class FullName
        {
            public string Forename { get; set; }
            public string Surname { get; set; }
        }
        private void FilteringDataByColumn()
        {
            IQueryable<FullName> names = from e in Employees
                                         select new FullName { Forename = e.FirstName, Surname = e.LastName };
        }  

        // Accediendo a los datos recogidos
        foreach (var emp in emps)
            Console.WriteLine("{0} {1}", emp.FirstName, emp.LastName);
    
        // Agrupando
        var emps = from e in Employees
                   group e by e.JobTitle into eGroup
                   select new { Job = eGroup.Key, CountOfEmployees = eGroup.Count() };

        // Notacion de punto para acceder a los miembros de los datos recogidos
        var emps = from e in Employees
                   select new
                   {
                       FirstName = e.FirstName,
                       LastName = e.LastName,
                       Job = e.JobTitle1.Job
                   };
    }
}
