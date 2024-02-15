namespace Proyecto_School.class.Entities
{
    public class Person
    {

    #region "Atributos"

        public int _PersonID
        public string? _LastName
        public string? _FirstName
        public DateTime? _HireDate
        public DateTime? _EnrollmentDate
        public string? _Discriminator

    #endregion

    #region "Propiedades"

    public int PersonID
    {
        get {return _PersonID;}
        set {_PersonID = value;}
    }

    public string? LastName
    {
        get {return _LastName;}
        set {_LastName = value;}
    }

    public string? FirstName
    {
        get {return _FirstName;}
        set {_FirstName = value}
    }

    public DateTime? HireDate
    {
        get {return _HireDate;}
        set {_HireDate = value;}
    }

    public DateTime? EnrollmentDate
    {
        get {return _EnrollmentDate;}
        set {_EnrollmentDate = value}
    }

    public string? Discriminator
    {
        get {return _Discriminator;}
        set {_Discriminator = value;}
    }

    #endregion

    }


}