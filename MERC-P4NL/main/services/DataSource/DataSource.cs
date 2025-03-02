using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MERC_P4NL.main.services.DataSource
{
    public interface DataSource
    {
        public Supabase.Client client { get; set; }
    }
}
