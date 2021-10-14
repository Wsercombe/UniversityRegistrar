using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Department
  {
    public Department()
    {
      this.JoinEntities3 = new HashSet<CourseDepartment>();
      this.JoinEntities2 = new HashSet<DepartmentStudent>();
    }

    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public virtual ICollection<CourseDepartment> JoinEntities3 { get; set; }
    public virtual ICollection<DepartmentStudent> JoinEntities2 { get; set; }
  }
}