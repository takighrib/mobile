using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
public class Company
{
    public string Id { get; set; }
    public string Name { get; set; }
  /*  public ICollection<User> Users { get; set; } = new List<User>();
    public ICollection<People> People { get; set; } = new List<People>();
    public ICollection<ServiceOrder> ServiceOrders { get; set; } = new List<ServiceOrder>(); // Add this property
*/
}