﻿using System;
using System.Collections.Generic;
using MVCForum.Domain.DomainModel;

namespace MVCForum.Domain.Interfaces.Services
{
    public partial interface IBannedEmailService
    {
        BannedEmail Add(BannedEmail bannedEmail);
        void Delete(BannedEmail bannedEmail);
        IList<BannedEmail> GetAll();
        BannedEmail Get(Guid id);
        PagedList<BannedEmail> GetAllPaged(int pageIndex, int pageSize);
        PagedList<BannedEmail> GetAllPaged(string search, int pageIndex, int pageSize);
        IList<BannedEmail> GetAllWildCards();
        IList<BannedEmail> GetAllNonWildCards();
        bool EmailIsBanned(string email);
    }
}
