﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using FundsLibrary.InterviewTest.Common;
using FundsLibrary.InterviewTest.Service.Repositories;

namespace FundsLibrary.InterviewTest.Service.Controllers
{
    public class FundManagerController : ApiController
    {
        private readonly IFundManagerRepository _repository;

        // ReSharper disable once UnusedMember.Global
        public FundManagerController()
            : this(new FundManagerMemoryDb())
        {}

        public FundManagerController(IFundManagerRepository injectedRepository)
        {
            _repository = injectedRepository;
        }

        public async Task<Boolean> Delete(Guid id)
        {
            return await _repository.Delete(id);
        }

        public async Task<IEnumerable<FundManager>> Get()
        {
            return await _repository.GetAll();
        }

        public async Task<FundManager> Get(Guid id)
        {
            return await _repository.GetBy(id);
        }

        public async Task<Guid> Put(FundManager fundManager)
        {
            return await _repository.Update(fundManager);
        }

        public async Task<Guid> Post(FundManager fundManager)
        {
            return await _repository.Create(fundManager);
        }

    }
}
