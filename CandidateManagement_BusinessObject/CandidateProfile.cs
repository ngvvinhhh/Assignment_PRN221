﻿using System;
using System.Collections.Generic;

namespace CandidateManagement_BusinessObject;

public partial class CandidateProfile
{
    public string CandidateId { get; set; }

    public string Fullname { get; set; }

    public DateTime? Birthday { get; set; }

    public string ProfileShortDescription { get; set; }

    public string ProfileUrl { get; set; }

    public string PostingId { get; set; }

    public virtual JobPosting Posting { get; set; }
}
