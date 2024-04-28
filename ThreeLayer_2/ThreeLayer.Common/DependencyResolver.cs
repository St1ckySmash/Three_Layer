using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.BLL;
using ThreeLayer.DAL;

namespace ThreeLayer.Common
{
    public static class DependencyResolver
    {
        static private IOrganizationDB organizationDB;
        static private IOrganizationLogic organizationLogic;

        static public IOrganizationDB OrganizationDB
        { 
            get => organizationDB ?? (organizationDB = new OrganizationDB()); 
        }
        static public IOrganizationLogic OrganizationLogic 
        { 
            get => organizationLogic ?? (organizationLogic = new OrganizationLogic(OrganizationDB)); 
        }
    }
}
