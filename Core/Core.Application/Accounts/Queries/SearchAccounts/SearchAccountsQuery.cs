﻿using Core.Application.Accounts.Models.Enums;
using Core.Application.Accounts.Models.Views;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Application.Accounts.Queries.SearchAccounts
{
    public class SearchAccountsQuery : IRequest<AccountSearchResultsViewModel>
    {
        public SearchAccountsQuery()
        {
            //Default Search Options
            Page = 1;
            PageSize = 20;
            OrderBy = OrderBy.Name;
            OrderDirection = OrderDirection.ASC;
        }

        public int Page { get; set; }
        public int PageSize { get; set; }
        public OrderBy OrderBy { get; set; }
        public OrderDirection OrderDirection { get; set; }

    }
}
