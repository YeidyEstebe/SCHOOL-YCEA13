namespace Proyecto_School.class.Entities
{
    public class OnlineCourse
    {

        #region "Atributos"

            public int _CourseID
            public string? _URL
        
        #endregion


        #region "Propiedades"

       
        public int CourseID
        {
            get { return _CourseID; }
            set { _CourseID = value; }
        }
        
        public string? URL
        {
            get {return _URL}
            set {_URL = value}

        }

        #endregion 

    

    }




}