using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Boing,
        Airbus
    }
    public class Plane
    {
        //public Plane(PlaneType planetype, int capacity, DateTime manifacturalDate)
        //{
        //    Planetype = planetype;
        //    Capacity = capacity;
        //    ManifacturalDate = manifacturalDate;
        //}

        public int PlaneId { get; set; }
        public PlaneType Planetype { get; set; }
        public int Capacity { get; set; }
        public DateTime ManifacturalDate { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }


        public override string ToString()
        {
            return "PlaneId  "+PlaneId+"  PlaneType"+Planetype+"Capacity"+Capacity+"ManifacturalDate"+ManifacturalDate;
        }
        
    }
}
