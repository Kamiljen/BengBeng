﻿using BengBeng.MemberContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BengBeng.Repositories
{
    public static class MemberRepo
    {
        private static List<Member> Members = new List<Member>();
     

        public static bool SaveMember(Member member)
        {
            //if (!Members.Any(x=>x.Id == member.Id))
            //{
                Members.Add(member);
                return true;
            //}
            //return false;
        }

        public static Member GetMember(string id)
        {
            return Members.SingleOrDefault(x => x.Id == id);
        }
        public static List<Member> getMembers()
        {
            return Members;
        }
    }
}
