using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Customer
  {
    public Customer()
    {
      this.Stylists = new HashSet<Stylist>();
    }

    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ICollection<Stylist> Stylists { get; set; }

  }
}