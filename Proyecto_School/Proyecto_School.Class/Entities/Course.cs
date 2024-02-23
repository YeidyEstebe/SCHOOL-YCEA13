
using Proyecto_School.Class.Core;

namespace Proyecto_School.Class.Entities
{
    public class Course :BaseEntity
    {
        #region "Atributos"

        private int _CourseID;
        private string? _Title;
        private int _Credits;
        private int _DepartmentID;
        
        #endregion

        #region "Propiedades"

        
        public int CourseID
        {
            get { return _CourseID; }
            set { _CourseID = value; }
        }
                
        public string? Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        
        public int Credits
        {
            get { return _Credits; }
            set { _Credits = value; }
        }
        
        public int DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }
        

        #endregion

    }
}
