using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class UserInfoService
    {
        List<UserInfo> data = new List<UserInfo>();
        public UserInfoService()
        {
            for (int i = 0; i < 50_000; i++)
            {
                data.Add(new UserInfo() { Created = DateTime.Now, Id = Guid.NewGuid(), Name = i.ToString() });
            }
        }
        public Task<UserInfo[]> GetUserList(int index,int size)
        {
            return Task.FromResult(Enumerable.Range((index-1)*size,size+1).Select(c=>new UserInfo()
            {
                Name = c.ToString(),
                Id = Guid.NewGuid(),
                Created = DateTime.Now.AddSeconds(new Random().Next(10000))
            }).ToArray());
        }
    }
}
