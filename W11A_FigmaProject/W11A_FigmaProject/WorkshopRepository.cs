using System;
using System.Collections.Generic;
using System.Text;

namespace W11A_FigmaProject
{
    public static class WorkshopRepository
    {
        private static List<Workshop> _workshops;
        public static List<Workshop> Workshops
        {
            get
            {
                return _workshops;
            }
        }

        static WorkshopRepository()
        {
            _workshops = new List<Workshop>();
        }

    }
}
