﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PSO.Model
{
    class ProductSpecification
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public byte[] SpecData { get; set; }
        public string SpecDataExtension { get; set; }

        public void CreateSpec(string fileName)
        {
            var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            var br = new BinaryReader(fs);
            using (br)
            {
                using (fs)
                {
                    SpecData = br.ReadBytes((int)fs.Length);
                }
            }

        }
    }
}
