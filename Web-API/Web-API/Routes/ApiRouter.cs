using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Routes
{
    public static class ApiRouter
    {
        public static class User
        {
            public const string AddUser = "AddUser";
            public const string UpdateUser = "UpdateUser";
            public const string DeleteUser = "DeleteUser";
            public const string GetAllUser = "GetAllUser";
            public const string SerachUser = "SearchUser";

        }

        public static class PDC
        {
            public const string AddPDC = "AddPDC";
            public const string UpdatePDC = "UpdatePDC";
            public const string DeletePDC = "DeletePDC";
            public const string GetAllPDC = "GetAllPDC";
            public const string SerachPDC = "SearchPDC";

        }

        public static class Building
        {
            public const string AddBuilding = "AddBuilding";
            public const string UpdateBuilding = "UpdateBuilding";
            public const string DeleteBuilding = "DeleteBuilding";
            public const string GetAllBuilding = "GetAllBuilding";
            public const string SerachBuilding = "SearchBuilding";

        }
    }
}
