﻿using BengBeng.MemberContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace BengBeng.TournamentContext
{
    
    public class TournamentManager
    {
        private readonly TournamentFacade _facade;
        public TournamentManager(TournamentFacade facade)
        {
            _facade = facade;
        }
        public Tournament Createtournament(string name, DateTime to, DateTime from)
        {
            return _facade.CreateTournament(name,to, from);
        }

        public bool AddContestant(Member member, string tournamentName )
        {
            return _facade.AddContestant(member, tournamentName);
        }

        public Tournament GetTournament(string tournamentName)
        {
            return _facade.GetTournament(tournamentName);
        }

        public Tournament GetTournamentResult(string tournamentName)
        {
            return _facade.GetTournamentResult(tournamentName);
        }
    }
}
