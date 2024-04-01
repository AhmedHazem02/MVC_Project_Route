using Page_BLL.Interfaces;
using Page_DAL.Contexts;
using Page_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_BLL.Repositories
{
    public class DepartmentRepository :GenericRepository<Department>, IDepartmentRepository
    {
       public DepartmentRepository(MVCProjectDbContext dbContext): base(dbContext)
       {

       } 
    }
}
