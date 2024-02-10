


namespace Proyecto_School.Class.Entities
{
    public class Course
    {
        #region "Atributos"

        private int _CourseID;
        private string? _Title;
        private int _Credits;
        private int _DepartmentID;
        private DateTime _CreationDate;
        private DateTime? _ModifyDate;
        private int? _CreationUser;
        private int? _UserMod;
        private int? _UserDeleted;
        private DateTime? _DeletedDate;
        private bool _Deleted;
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
        
        public DateTime CreationDate
        {
            get { return _CreationDate; }
            set { _CreationDate = value; }
        }
        
        public DateTime? ModifyDate
        {
            get { return _ModifyDate; }
            set { _ModifyDate = value; }
        }
        
        public int? CreationUser
        {
            get { return _CreationUser; }
            set { _CreationUser = value; }
        }

        public int? UserMod
        {
            get { return _UserMod; }
            set { _UserMod = value; }
        }
        
        public int? UserDeleted
        {
            get { return _UserDeleted; }
            set { _UserDeleted = value; }
        }
        
        public DateTime? DeletedDate
        {
            get { return _DeletedDate; }
            set { _DeletedDate = value; }
        }
       
        public bool Deleted
        {
            get { return _Deleted; }
            set { _Deleted = value; }
        }


        #endregion

    }
}
