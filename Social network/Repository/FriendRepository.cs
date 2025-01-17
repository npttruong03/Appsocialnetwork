﻿using Social_network.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Social_network.Repository
{
    interface FriendRepository
    {
        Task<List<FriendResponse>> GetAllFriends();
        Task<List<FriendResponse>> GetAllFriendsId(long id);
    }
}