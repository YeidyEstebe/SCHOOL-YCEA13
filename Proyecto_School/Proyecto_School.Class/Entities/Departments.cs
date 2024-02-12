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
        public DateTime CreationDate { get; set;}
        public DateTime? ModifyDate { get; set;}
        public int CreationUser { get; set;}
        public int? UserMod { get; set;}
        public int? UserDeleted { get; set;}
        public DateTime? DeletedDate { get; set;}
        public bool Deleted { get; set;}

    }
}