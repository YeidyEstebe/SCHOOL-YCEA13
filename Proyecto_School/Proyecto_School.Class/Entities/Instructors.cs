namespace Proyecto_School.Class.Entities
{

    public class Instructors
    {

        #region "Atributos"

        public int _Id;
        public string? _LastName;
        public string? _FirstName;
        public DateTime? _HireDate; 
        
        #endregion

        #region "Propiedades" 

        public int Id

        {
            get { return _Id; }
            set { _Id = value;}

        }

        public string? LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

         public string? FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public DateTime? HireDate
        {
            get { return _HireDate ; }
            set { _HireDate  = value; }
        }
        
        
        
        #endregion

    }


}