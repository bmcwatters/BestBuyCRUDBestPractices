using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyCRUDBestPractices
{
    public interface IDepartmentRepository
    {
        
        IEnumerable<Department> GetAllDepartments();
        public void InsertDepartment(string name);

    }




    
}
