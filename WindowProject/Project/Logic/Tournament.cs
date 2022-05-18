﻿using System;
using System.Collections.Generic;

namespace Project.Logic
{
    public abstract class Tournament
    {
        protected List<Team> teams = new List<Team>();
        protected List<Judge> judges = new List<Judge>();
        protected List<Game> games = new List<Game>();
        protected string name = "";
        protected int state = 1;

        public Tournament(string name)
        {
            this.name = name;
        }

        public void addTeam(Team team)
        {
            teams.Add(team);
        }

        public void addJudge(Judge judge)
        {
            judges.Add(judge);
        }

        public void removeTeam(Team team)
        {
            teams.Remove(team);
        }

        public void removeJudge(Judge judge)
        {
            judges.Remove(judge);
        }

        public void changeState()
        {
            state++;
        }

        public virtual string getCategory()
        {
            return "";
        }
        public string getName()
        {
            return name;
        }
        public int getState()
        {
            return state;
        }

        public override string ToString()
        {
            string toSave = $"T,{name},{getCategory()}\n";
            foreach(Team t in teams)
            {
                toSave += t.ToString();
            }
            return toSave;
        }

        public string showResults()
        {
            string result = "";
            foreach (Team team in teams)
            {
                result += team.ToString();
            }
            return result;
        }
    }
}
