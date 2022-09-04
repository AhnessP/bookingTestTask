using System.IO;
using System.Text.Json;

namespace bookingTestTask.Helpers
{
    internal class DataReader
    {
        private readonly string PathToTestDataJsonFile =
            Directory.GetParent(@"../../../").FullName + "/TestData/TestData.json";

        public DataModel.DataModel ReadDataFromTestData()
        {
            string jsonFile;

            jsonFile = File.ReadAllText(PathToTestDataJsonFile);

            DataModel.DataModel dataModelObject = JsonSerializer.Deserialize<DataModel.DataModel>(jsonFile);
            return dataModelObject;
        }
    }
}