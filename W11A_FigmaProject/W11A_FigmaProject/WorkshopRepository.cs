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
            _workshops = new List<Workshop>
            {
                new Workshop
                {Date = new DateTime(2012, 02, 12),
                 Title = "games"
                },
                 new Workshop
                {Date = new DateTime(2012, 02, 13),
                 Title = "movies"
                },
                  new Workshop
                {Date = new DateTime(2012, 02, 14),
                 Title = "music"
                },
                   new Workshop
                {Date = new DateTime(2012, 02, 15),
                 Title = "shit"
                },


            };
        }

    }
}
