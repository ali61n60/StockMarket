using Microsoft.EntityFrameworkCore;
using ModelStd.DB.Stock;
using RepositoryStd;
using ServiceStd.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceStd
{
    public class CustomGroupService : ICustomGroupService
    {
        public List<CustomGroup> GetAllGroups()
        {
            StockDbContext s = new StockDbContext();
            return s.CustomGroups.ToList();
        }

        public List<CustomGroupMember> GetMembers(int groupId)
        {
            StockDbContext s= new StockDbContext();
            return s.CustomGroupMembers.Include(c=>c.Symbol).Where(c => c.GroupId == groupId).ToList();
        }
    }
}
