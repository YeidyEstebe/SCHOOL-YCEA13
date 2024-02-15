


namespace Proyecto_School.Class.Entities
{
    public class CourseInstructor
    {
        
     #region "Atributos"

         public int _CourseID;
         public int _PersonID;
     
     #endregion

     #region "Propiedades"

      public int CourseID
         {
         get { return _CourseID; }
         set { _CourseID = value; }
         }
      public int PersonID
         {
         get { return _PersonID; }
         set { _PersonID = value; }
         }
          
      #endregion

    }   
}    