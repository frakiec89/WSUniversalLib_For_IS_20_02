using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Material
    {
        public int MaterialId { get; set; }
        public float DefectMaterial { get; set; }
    }


    public class MaterialsMock
    {
        public List<Material> Materials { get; set; }
        = new List<Material>
        {
            new Material(){  MaterialId=1 , DefectMaterial=0.003f} ,

            new Material(){ MaterialId=2 , DefectMaterial=0.0012f}
        };
    }
}
