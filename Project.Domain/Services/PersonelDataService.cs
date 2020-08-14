namespace Project.Domain
{
    public sealed class PersonelDataService : BaseDataServices<Personel>
    {
        public int InsertCommand(Personel personel)
        {
            string query = "INSERT INTO Personel VALUES (@Name,@LastName)";
            return ExecuteCommandText(query, personel);
        }

    }
}
