using CsProjeDemo2.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProjeDemo2;

public class ReadFolder
{
    private string path = "~/CSProjeDemo/CsProjeDemo2_ConsoleApp/personnel.json";
    public static List<Personnel> EmployeeListRead(string path)
    {
        string json = File.ReadAllText(path);
        return JsonConvert.DeserializeObject<List<Personnel>>(json);
    }
}
