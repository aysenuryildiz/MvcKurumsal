using System.Collections.Generic;

namespace Project.Domain
{
    public sealed class PersonelDataService : BaseDataServices<Personel>
    {
        public int InsertCommand(Personel personel)
        {
            string query = "INSERT INTO Personel VALUES (@Name,@LastName)";
            return ExecuteCommandText(query, personel);
        }


        public Personel GetData()
        {
            string query = "SELECT * FROM Personel where Id = 1";
            return GetData(query);
        }

        public List<Personel> GetDataList()
        {
            string query = "Select * From Personel";
            return GetDataList(query);
        }
    }
}
