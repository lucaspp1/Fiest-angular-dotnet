using System.Collections.Generic;
namespace esseCoco.model
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Password { get; set; }
        public virtual string Login { get; set; }
        public virtual List<Image> Images { get; set; }
    }
}