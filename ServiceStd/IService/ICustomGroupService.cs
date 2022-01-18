using ModelStd.DB.Stock;
using System.Collections.Generic;

namespace ServiceStd.IService
{
    public interface ICustomGroupService
    {
        List<CustomGroup> GetAllGroups();
        List<CustomGroupMember> GetMembers(int groupId);
    }
}
