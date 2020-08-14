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
        [TestMethod]
        public void GetData()
        {
            var result = service.GetData();
            Debug.WriteLine(result.Name);
        }
        
        [TestMethod]
        public void GetDataList()
        {
            var list = service.GetDataList();
            foreach (var item in list)
            {
                Debug.Write(item.Name);

            }
        }
    }
}
