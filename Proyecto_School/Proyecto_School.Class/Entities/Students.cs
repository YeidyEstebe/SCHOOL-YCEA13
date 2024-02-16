namespace Proyecto_School.Class.Entites
{
    public class Students
    {
        #region "Atributos"

        public int _Id;
        public String? _LastName;
        public String? _FirstName;
        public DateTime _EnrollmentDate;
        
        #endregion

        #region "Propiedades"

        
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        
        public String? LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public String? FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public DateTime EnrollmentDate
        {
            get { return _EnrollmentDate; }
            set { _EnrollmentDate = value; }
        }


        #endregion

    }

}