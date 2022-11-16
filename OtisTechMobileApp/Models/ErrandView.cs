using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtisTechMobileApp.Models
{
    public class ErrandView
    {
        public int Id { get; set; }
        public string ErrandText { get; set; }
        public int ElevatorId { get; set; }
        public bool Active { get; set; }
        public string Status { get; set; }


    }
}
