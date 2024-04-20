namespace HomeSchoolHub.Authentication.Presentation.Auth
{
    public static class Policies
    {
        public const string System = "RequireSystem";
        public const string Admin = "RequireAdmim";
        public const string Teacher = "RequireTeacher";
        public const string Student = "RequireStudent";
        public const string Parent = "RequireParent";
        public const string ParentAuth = "RequireParentAuth";
        public const string StudentAuth = "RequireStudentAuth";
    }
}
