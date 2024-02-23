using System.Data.SqlTypes;

namespace Proyecto_School.Class.Entities
{
    public class Departments

    {
        public int DepartmentID { get; set;}
        public string? Name { get; set;}
        public SqlMoney Budget { get; set;}
        public DateTime StartDate { get; set;}
        public int Administrator { get; set;}
     
    }
}