using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace communitylibs
{
    public class SP_CITIZEN_VO
    {
        
        public string FIRST_NAME { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string PLACE_OF_BIRTH { get; set; }
        public string ORIGIN_OF_BIRTH { get; set; }
        public string SECOND_NAME { get; set; }
        public string THIRD_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string MOTHER_NAME { get; set; }
        public string GENDER { get; set; }
        public string ID_ISSUE_DATE { get; set; }
        public string MARITAL_STATUS { get; set; }
        public int ID_NUMBER { get; set; }
        public int RECORD_NUMBER { get; set; }

        
        public string FullName
        {
            get
            {
                return FIRST_NAME +' '+ LAST_NAME;
            }
        }
    }
}
