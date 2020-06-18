using Newtonsoft.Json;
using System.IO;
using Lessons.VM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.DbLayer
{
    public class FileIOService
    {
        private readonly string PATH;

        public FileIOService(string path)
        {
            PATH = path;
        }

        public PageVM LoadData()
        {
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new PageVM();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<PageVM>(fileText);
            }
        }

        public void SaveData(PageVM pageVM)
        {
            using (StreamWriter write = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(pageVM);
                write.Write(output);
            }
        }
    }
}
