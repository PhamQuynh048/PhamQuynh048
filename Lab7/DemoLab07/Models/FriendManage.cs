using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLab07.Models
{
    class FriendManage
    {
        public static List<Friend> GetFriends()
        {
            var friends = new List<Friend>();

            friends.Add(new Friend { FriendId = 1, Name = "Tran An", Age = "19", CoverImage = "Assets/quynh1.jpg" });
            friends.Add(new Friend { FriendId = 2, Name = "Hong Hanh", Age = "19", CoverImage = "Assets/vịt.jpg" });
            friends.Add(new Friend { FriendId = 3, Name = "Ngoc Quynh", Age = "19", CoverImage = "Assets/fpt.jpg" });

            return friends;
        }
    }
}
