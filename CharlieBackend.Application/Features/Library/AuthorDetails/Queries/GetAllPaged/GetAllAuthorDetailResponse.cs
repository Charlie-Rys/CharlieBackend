using CharlieBackend.Domain.Entities.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Features.Library.AuthorDetails.Queries.GetAllPaged
{
    public class GetAllAuthorDetailResponse
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }

        public string Biography { get; set; }
        public string Website { get; set; }
        public string SocialMediaHandle { get; set; }
        public string Awards { get; set; }


       
    }
}
