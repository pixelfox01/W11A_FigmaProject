using System;
using System.Collections.Generic;
using System.Text;

namespace W11A_FigmaProject
{
    public class WorkshopRepository
    {

        private List<Workshop> _workshops;

        public List<Workshop> Workshops
        {
            get
            {
                return _workshops;
            }
        }

        public WorkshopRepository()
        {
            _workshops = new List<Workshop>();
        }

    }
}
