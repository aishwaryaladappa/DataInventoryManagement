using System;
using Newtonsoft.Json;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInventoryManagement
{
    public  class FetchJsonForRice
    {
        public Rice Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);

                }
                catch (Exception)
                {
                    return null;
                }
            }


        }
    }
}
