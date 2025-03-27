using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeamManager: ITeamService
    {
        private readonly ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public List<Team> GetAllList()
        {
            return _teamDal.GetAllList();
        }

        public Team GetById(int id)
        {
            return _teamDal.GetById(id);
        }

        public void Insert(Team team)
        {
            _teamDal.Insert(team);
        }

        public void Update(Team team)
        {
            _teamDal.Update(team);
        }

        public void Delete(Team team)
        {
            _teamDal.Delete(team);
        }

       
    }
}
