using MERC_P4NL.main.enums;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using Supabase.Postgrest.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MERC_P4NL.main.models
{
    [Table(TableListEnums.users)]
    public class UserModel : BaseModel
    {
        [PrimaryKey(TableColumnEnums.id)]
        public int Id { get; set; }

        [Column(TableColumnEnums.steamCd)]
        public string SteamCd { get; set; }

        [Column(TableColumnEnums.mercenary)]
        public string Mercenary { get; set; }

        [Column(TableColumnEnums.auth)]
        public string Auth { get; set; }

        [Column(TableColumnEnums.version)]
        public string Version { get; set; }

        [Column(TableColumnEnums.updated)]
        public string Updated { get; set; }

        [Column(TableColumnEnums.created)]
        public string Created { get; set; }

        public static implicit operator UserModel(ModeledResponse<UserModel> v)
        {
            return v.Model;
        }
    }
}
