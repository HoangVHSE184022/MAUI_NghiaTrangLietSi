using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_NghiaTrangLietSi.DAL.Models
{
    public class LietSi : RealmObject
    {
        [PrimaryKey]
        public string LietSiId { get; set; } = Guid.NewGuid().ToString(); 
        public string HoVaTen { get; set; }   
        public string QueQuan { get; set; }   
        public int NamSinh { get; set; }    
        public int NamMat { get; set; }    
        public string DonVi { get; set; }   
        public string CapBac { get; set; }  
        public string NoiYenNghi { get; set; }
        public double ViTriMoX { get; set; } 
        public double ViTriMoY { get; set; }
    }
}
