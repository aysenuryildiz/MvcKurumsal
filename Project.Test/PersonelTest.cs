using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain = Project.Domain;
namespace Project.Test
{
    [TestClass]
    public class PersonelTest
    {
        private Domain.PersonelDataService service = new Domain.PersonelDataService();
        [TestMethod]
        public void Insert()
        {

            Domain.Personel personel = new Domain.Personel()
            {
                Name = "Ayşenur",
                LastName = "Yıldız"
            };
            int result = service.InsertCommand(personel);
            Debug.WriteLine(result);
        }
    }
}
