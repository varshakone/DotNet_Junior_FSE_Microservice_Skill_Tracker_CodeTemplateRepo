﻿using MongoDB.Driver;
using Skill_MicroService.BusinessLayer.Interface;
using Skill_MicroService.BusinessLayer.Service.Repository;
using Skill_MicroService.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Skill_MicroService.BusinessLayer.Service
{
    public class SkillService : ISkillService
    {

        private readonly ISkillRepository _skillRepository;

        /// <summary>
        /// Create Object of type IUserRepository
        /// </summary>
        /// <param name="userRepository"></param>
        public SkillService(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        /// <summary>
        /// Save new skill upgarded by full stack engineer into database
        /// </summary>
        /// <param name="skill"></param>
        /// <returns></returns>
        
        public async Task<string> AddNewSkill(Skill skill)
        {
            //Business Logic to call SkillRepository method
            throw new NotImplementedException();
        }

        /// <summary>
        /// delete skill of full stack engineer from database
        /// </summary>
        /// <param name="skillname"></param>
        /// <returns></returns>
       public async Task<int> DeleteSkill(string skillname)
        {
            //Business Logic to call SkillRepository method
            throw new NotImplementedException();
        }


        /// <summary>
        /// update skill upgarded by full stack engineer from database
        /// </summary>
        /// <param name="skill"></param>
        /// <returns></returns>

        public async Task<int> EditSkill(Skill skill)
        {
            //Business Logic to call SkillRepository method
            throw new NotImplementedException();
        }
    }
}
