using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterLib
{
    public class AvengersTeam
    {
        private List<IDescribable> members;

        public AvengersTeam()
        {
            members = new List<IDescribable>();
        }

        public AvengersTeam(AvengersTeam other)
        {
            members = new List<IDescribable>(other.members);
        }

        public void AddMember(IDescribable member)
        {
            if (member is Ironman ironman)
            {
                members.Add(new Ironman(ironman));
            }
            else if (member is DoctorStrange strange)
            {
                members.Add(new DoctorStrange(strange));
            }
            else if (member is Hulk hulk)
            {
                members.Add(new Hulk(hulk));
            }
            else if (member is Widow widow)
            {
                members.Add(new Widow(widow));
            }
        }

        public void RemoveMember(string name)
        {
            members.RemoveAll(m => m.GetName() == name);
        }

        public void ClearTeam()
        {
            members.Clear();
        }

        public IDescribable GetMostPowerful()
        {
            if (!members.Any()) return null;
            return members.OrderByDescending(m => m.GetPower()).First();
        }

        public void CapitalizeNames()
        {
            foreach (var member in members)
            {
                string name = member.GetName();
                if (!string.IsNullOrEmpty(name))
                {
                    // Потребує сеттера
                }
            }
        }

        public IReadOnlyList<IDescribable> GetMembers() => members.AsReadOnly();
    }
}