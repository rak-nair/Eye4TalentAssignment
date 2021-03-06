﻿using AssignmentAPI.Data.Entities;
using AssignmentAPI.Services;
using System.Collections.Generic;

namespace AssignmentAPI.Models
{
    //Output Model for Paged Matches
    public class PagedMatchViewModel
    {
        public List<MatchEntity> Matches { get; set; }
        public PagingLinkBuilder Pages { get; set; }
    }
}