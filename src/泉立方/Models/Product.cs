using System.Collections.Generic;

namespace 泉立方.Models
{
    public class Product
    {
        private readonly List<User> _user = new List<User>();

        public Product(string productname, IEnumerable<User> users)
        {
            ProductName = productname;
            _user.AddRange(users);
        }

        public string ProductName { get; private set; }

        public IEnumerable<User> Users
        {
            get { return new List<User>(_user); }
        }
    }
}